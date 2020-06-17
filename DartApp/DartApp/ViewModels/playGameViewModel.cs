using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace DartApp.ViewModels
{
    public class PlayGameViewModel : INotifyPropertyChanged
    {
        private int scoreToWin;
        private int turnScore, i;
        public ICommand AddScoreCommand { get; }
        public int throwScore;
        public bool isWin;
        public bool isTooMuch;
        public bool playingGame;
        
        public PlayGameViewModel(int game)
        {      
            i = 1;
            scoreToWin = game;
            AddScoreCommand = new Command(() => addScore(ThrowScore));
            isWin = false;
            isTooMuch = false;
            playingGame = true;
            Multiplier = 1;
        }

        public int Multiplier { get; set; }

        public bool PlayingGame
        {
            get
            {
                return playingGame;
            }
            set
            {
                playingGame = value;
                OnPropertyChanged();
            }
        }

        public bool IsTooMuch
        {
            get
            {
                return isTooMuch;
            }
            set
            {
                isTooMuch = value;
                OnPropertyChanged();
            }
        }

        public bool IsWin
        {
            get
            {
                return isWin;
            }
            set
            {
                isWin = value;
                OnPropertyChanged();
            }
        }

        public int ThrowScore
        {
            get
            {
                return throwScore;
            }
            set
            {
                throwScore = value;
                OnPropertyChanged();
            }
        }
        public int I
        {
            get
            {
                return i;
            }
            set
            {
                i = value;
                OnPropertyChanged();
            }
        }

        public int ScoreToWin
        {
            get
            {
                return scoreToWin;
            }
            set
            {
                scoreToWin = value;
                OnPropertyChanged();
            }
        }
        public int TurnScore 
        {
            get
            {
                return turnScore;
            }
            set
            {
                turnScore = value;
                OnPropertyChanged();
            }
        }

        private void addScore(int score)
        {
            ThrowScore = 0;
            IsTooMuch = false;
            
            if(I <= 2)
            {
                TurnScore += Multiplier * score;
                I++;
            }
            else
            {
                TurnScore += score;
                if (ScoreToWin - TurnScore > 0)
                {                    
                    ScoreToWin -= TurnScore;                  
                }
                else if (ScoreToWin - TurnScore < 0)
                {
                    IsTooMuch = true;
                }
                else if(ScoreToWin - TurnScore == 0)
                {
                    IsWin = true;
                    PlayingGame = false;
                }
               
                TurnScore = 0;
                I = 1;
            }
            Multiplier = 1;
        }

       

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        
    }
}
