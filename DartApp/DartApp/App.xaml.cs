using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DartApp.Services;
using DartApp.Views;

namespace DartApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<SQLiteDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
