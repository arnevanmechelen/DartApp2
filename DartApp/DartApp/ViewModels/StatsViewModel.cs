using DartApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DartApp.ViewModels
{
    public class StatsViewModel : BaseViewModel
    {
        public ObservableCollection<Stat> Stats { get; set; }
        public Command LoadStatsCommand { get; set; }
        public int bulls;

        public StatsViewModel()
        {
            Stats = new ObservableCollection<Stat>();
            LoadStatsCommand = new Command(async () => await ExecuteLoadStatsCommand());
        }

        public int Bulls
        {
            get
            {
                return bulls;
            }
            set
            {
                bulls = value;
                OnPropertyChanged();
            }
        }

        async Task ExecuteLoadStatsCommand()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                Stats.Clear();
                var stats = await DataStore.GetStatsAsync(true);
                foreach (Stat stat in stats)
                {
                    Stats.Add(stat);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
