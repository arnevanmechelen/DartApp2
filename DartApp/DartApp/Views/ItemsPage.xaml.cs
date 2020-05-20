using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DartApp.Models;
using DartApp.Views;
using DartApp.ViewModels;

namespace DartApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var item = (Item)layout.BindingContext;
            await Navigation.PushAsync(new NavigationPage(new play301Page()));
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.IsBusy = true;
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Three01Button_Clicked(object sender, EventArgs e)
        {
            var item = new Item();
            item.Id = "301";
            await Navigation.PushAsync(new NavigationPage(new play301Page()));
        }

        private async void Four01Button_Clicked(object sender, EventArgs e)
        {
            var item = new Item();
            item.Id = "401";
            await Navigation.PushAsync(new NavigationPage(new play301Page()));
        }
    }
}