using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DartApp.Models;
using DartApp.ViewModels;

namespace DartApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        

        public ItemDetailPage()
        {
            InitializeComponent();

     

            
            

            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
        }
    }
}