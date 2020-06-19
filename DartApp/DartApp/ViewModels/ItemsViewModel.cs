using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using DartApp.Models;
using DartApp.Views;

namespace DartApp.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        //public ObservableCollection<Stat> Stats { get; set; }
        //public Command LoadItemsCommand { get; set; }

        //public ItemsViewModel()
        //{
        //    Title = "Game";
        //    Stats = new ObservableCollection<Stat>();
        //    LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

        //    MessagingCenter.Subscribe<NewItemPage, Stat>(this, "AddStat", async (obj, stat) =>
        //    {
        //        var newStat = stat as Stat;
        //        Stats.Add(newStat);
        //        await DataStore.AddStatAsync(newStat);
        //    });
        //}

        //async Task ExecuteLoadItemsCommand()
        //{
        //    IsBusy = true;

        //    try
        //    {
        //        Stats.Clear();
        //        var items = await DataStore.GetStatsAsync(true);
        //        foreach (var item in items)
        //        {
        //            Stats.Add(item);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //    }
        //    finally
        //    {
        //        IsBusy = false;
        //    }
        //}
    }
}