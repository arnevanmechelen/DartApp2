using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DartApp.ViewModels
{
    public class playGameViewModel : INotifyPropertyChanged
    {
        private int scoreToWin, turnScore, totalGameScore, i;
        public ICommand AddScoreCommand { get; }

        public playGameViewModel()
        {
            scoreToWin = 301;
            turnScore = 0;
            totalGameScore = scoreToWin;
            i = 1;

            AddScoreCommand = new Command(() => addScore(turnScore));
        }

        public int ScoreToWin { get; set; }
        public int TurnScore { get; set; }
        public int TotalGameScore { get; set; }

        private void addScore(int score)
        {
            if(i <= 3)
            {
                turnScore += score;
                i++;
            }
            else
            {
                totalGameScore -= turnScore;
                i = 1;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
