using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DartApp.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddStatAsync(T item);
        Task<bool> UpdateStatAsync(T item);
        Task<bool> DeleteStatAsync(string name);
        Task<T> GetStatAsync(string name);
        Task<IEnumerable<T>> GetStatsAsync(bool forceRefresh = false);
    }
}
