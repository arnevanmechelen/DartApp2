using DartApp.ViewModels;
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
    public partial class play301Page : ContentPage
    {
        public play301Page()
        {
            InitializeComponent();
            playGameViewModel viewModel = new playGameViewModel();
            this.BindingContext = viewModel;

            
        }
    }
}