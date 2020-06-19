using DartApp.Models;
using DartApp.Services;
using DartApp.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DartApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatsPage : ContentPage
    {
        StatsViewModel viewModel;

        public StatsPage()
        {
            InitializeComponent();

            viewModel = new StatsViewModel();
            this.BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Stats.Count == 0)
                viewModel.LoadStatsCommand.Execute(null);
        }
    }
}