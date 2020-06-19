using DartApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DartApp.Services
{
    public class SQLiteDataStore : IDataStore<Stat>
    {
        private StatContext context = new StatContext();
        private Stat bulls = new Stat();
        private Stat wins = new Stat();

        public SQLiteDataStore()
        {
            bulls.Name = "bulls";
            bulls.Amount = 0;
            wins.Name = "wins";
            wins.Amount = 0;
        }

        public async Task<IEnumerable<Stat>> GetStatsAsync(bool forceRefresh = false)
        {
            return await context.Stats.ToListAsync();
        }

        public async Task<Stat> GetStatAsync(string name)
        {
            return await context.Stats.SingleAsync(stat => stat.Name == name);
        }

        public async Task<bool> UpdateStatAsync(Stat stat)
        {
            return await SaveChangesAsync();
        }

        public async Task<bool> AddStatAsync(Stat stat)
        {
            try
            {
                await context.Stats.AddAsync(stat);

                return await SaveChangesAsync();
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteStatAsync(string name)
        {
            Stat stat = await GetStatAsync(name);
            context.Stats.Remove(stat);

            return await SaveChangesAsync();
        }

        private async Task<bool> SaveChangesAsync()
        {
            int n = await context.SaveChangesAsync();

            if(n != 0)
            {
                return true;
            }
            return false;
        }
    }
}
