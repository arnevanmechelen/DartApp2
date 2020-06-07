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
        PlayGameViewModel viewModel;

        public play301Page(int game)
        {
            InitializeComponent();
            viewModel = new PlayGameViewModel(game);
            this.BindingContext = viewModel;

            
        }

        private void scoreButton_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int score = Convert.ToInt32(btn.Text);
            viewModel.ThrowScore = score;
        }

        private void bullsButton_Clicked(object sender, EventArgs e)
        {
            viewModel.ThrowScore = 50;
        }

        private void outerButton_Clicked(object sender, EventArgs e)
        {
            viewModel.ThrowScore = 25;
        }

        private void doubleButton_Clicked(object sender, EventArgs e)
        {
            viewModel.Multiplier = 2;
        }

        private void tripleButton_Clicked(object sender, EventArgs e)
        {
            viewModel.Multiplier = 3;
        }
    }
}