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
    public class DealerVM : GlobalEventHandler
    {
        BlackJackVM _GameInstance;

        public DealerVM()
        {

        }
        public DealerVM(BlackJackVM gameInstance)
        {
            _GameInstance = gameInstance;
            Hand = new ObservableCollection<Card>();
        }
        public ObservableCollection<Card> Hand { get; set; }

        private ICommand _DealerHitCommand;
        public ICommand DealerHitCommand
        {
            get
            {
                if (_DealerHitCommand == null)
                    _DealerHitCommand = new DelegateCommand(Hit);

                return _DealerHitCommand;
            }
        }
        public void Hit()
        {
            Card cardPicked = _GameInstance.Draw();
            Hand.Add(cardPicked);
            _GameInstance.DealerScore += cardPicked.CardWorth;
            RaisePropertyChanged("DealerScore");
        }
    }
}
