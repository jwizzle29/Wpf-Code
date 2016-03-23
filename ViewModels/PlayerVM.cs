using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BlackJack_V1._1.DataModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace BlackJack_V1._1.ViewModels
{
    public class PlayerVM : GlobalEventHandler
    {
        BlackJackVM _GameInstance;
        public ObservableCollection<Card> Hand { get; set; }
        public PlayerVM()
        {

        }
        public PlayerVM(BlackJackVM gameInstance)
        {
            _GameInstance = gameInstance;
            Hand = new ObservableCollection<Card>();          
        }
        public Card SelectedCard { get; set; }

        private ICommand _PlayerHitCommand;
        public ICommand PlayerHitCommand
        {
            get
            {
                if (_PlayerHitCommand == null)
                    _PlayerHitCommand = new DelegateCommand(Hit);

                return _PlayerHitCommand;
            }
        }

        public void Hit()
        {
            Card cardPicked = _GameInstance.Draw();
            Hand.Add(cardPicked);
            _GameInstance.PlayerScore += cardPicked.CardWorth;
            RaisePropertyChanged("PlayerScore");
        }

        private ICommand _PlayerStopCommand;
        public ICommand PlayerStopCommand
        {
            get
            {
                if (_PlayerStopCommand == null)
                    _PlayerStopCommand = new DelegateCommand(Stop);

                return _PlayerStopCommand;
            }
        }

        public void Stop()
        {
            _GameInstance.IsGameOn = false;
            _GameInstance.CheckScores();
        }

    }
}
