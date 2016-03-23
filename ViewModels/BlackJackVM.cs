using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack_V1._1.ViewModels;
using BlackJack_V1._1.DataModels;
using System.Windows.Input;

namespace BlackJack_V1._1.ViewModels
{
    public class BlackJackVM : GlobalEventHandler
    {
        static private PlayerVM _PlayerInstance;
        static private DealerVM _DealerInstance;
        static private int FULL_DECK = 52;
        private GameDeck _GameDeck;
        private BlackJackVM _GameInstance;
        private int _CardCounter;
        private Random _CardPicker;
        private int _PlayerScore;
        private int _DealerScore;
        public string PlayerLabel { get; set; }
        public string DealerLabel { get; set; }
        static private int MAX_SCORE = 21;
        static bool _IsGameOn { get; set; }
        public BlackJackVM()
        {           
        }

        public bool IsGameOn {
            get { return _IsGameOn; }
            set
            {
                if (_IsGameOn == value)
                    return;
                _IsGameOn = value;
                RaisePropertyChanged("IsGameOn");
            }
        }
        public void WillDealerHit()
        {
            if(DealerScore > 12 && DealerScore < 18)
            {
                DealerInstance.Hit();
                WillDealerHit();
            }
            if(DealerScore < 17 && DealerScore <= MAX_SCORE)
            {
                Random hitchance = new Random();
                int percentage = hitchance.Next(0, 99);
                if(percentage < 35)
                {
                    DealerInstance.Hit();
                }
            }
            if(DealerScore > 18 && DealerScore <= MAX_SCORE)
            {
                Random hitchance = new Random();
                int percentage = hitchance.Next(0, 99);
                if (percentage > 75)
                {
                    DealerInstance.Hit();
                }
            }
        }
        public void CheckScores()
        {
            WillDealerHit();
            int pscore = PlayerScore;
            int dscore = DealerScore;           
            if(PlayerScore <= MAX_SCORE && DealerScore <= MAX_SCORE)
            {
                if(PlayerScore > DealerScore)
                {
                    PlayerLabel = "Win";
                    DealerLabel = "Lose";
                }
                else if(DealerScore > PlayerScore)
                {
                    DealerLabel = "Win";
                    PlayerLabel = "Lose";
                }
            }
            else if(PlayerScore > MAX_SCORE && DealerScore <= MAX_SCORE)
            {
                DealerLabel = "Win";
                PlayerLabel = "Bust";
            }
            else if(DealerScore > MAX_SCORE && PlayerScore <= MAX_SCORE)
            {
                PlayerLabel = "Win";
                DealerLabel = "Bust";
            }
            else if(DealerScore > MAX_SCORE && PlayerScore > MAX_SCORE)
            {
                PlayerLabel = "Bust";
                DealerLabel = "Bust";
            }
            else if(DealerScore == PlayerScore && (DealerScore <= MAX_SCORE && PlayerScore <= MAX_SCORE))
            {
                PlayerLabel = "Tie";
                DealerLabel = "Tie";
            }
            RaisePropertyChanged("PlayerLabel");
            RaisePropertyChanged("DealerLabel");
        }

        #region Public properties
        public int PlayerScore
        {
            get { return _PlayerScore; }
            set
            {
                if (_PlayerScore == value)
                    return;
                _PlayerScore = value;
                RaisePropertyChanged("PlayerScore");
            }
        }
        public int DealerScore
        {
            get { return _DealerScore; }
            set
            {
                if (_DealerScore == value)
                    return;
                _DealerScore = value;
                RaisePropertyChanged("DealerScore");
            }
        }
        public PlayerVM PlayerInstance
        {
            get { return _PlayerInstance; }
            set
            {
                if (_PlayerInstance == value)
                    return;

                _PlayerInstance = value;
                RaisePropertyChanged("PlayerInstance");
            }
        }

        public DealerVM DealerInstance
        {
            get { return _DealerInstance; }
            set
            {
                if (_DealerInstance == value)
                    return;

                _DealerInstance = value;
                RaisePropertyChanged("DealerInstance");
            }
        }

        public GameDeck GameDeck
        {
            get { return _GameDeck; }
            set
            {
                if (_GameDeck == value)
                    return;
                _GameDeck = value;
                RaisePropertyChanged("GameDeck");
            }
        }
        public int CardCounter
        {
            get { return _CardCounter; }
            set
            {
                if (_CardCounter == value)
                    return;
                _CardCounter = value;
                RaisePropertyChanged("CardCounter");
            }
        }
        public BlackJackVM GameInstance
        {
            get { return _GameInstance; }
            set
            {
                if (_GameInstance == value)
                    return;

                _GameInstance = value;
                RaisePropertyChanged("GameInstance");
            }
        }
        #endregion

        #region Commands
        private ICommand _StartGameCommand;
        public ICommand StartGameCommand
        {
            get
            {
                if (null == _StartGameCommand)
                    _StartGameCommand = new DelegateCommand(StartGame);

                return _StartGameCommand;
            }
        }       
        public void ResetData()
        {
            PlayerScore = 0;
            DealerScore = 0;
            PlayerLabel = null;
            DealerLabel = null;           
            RaisePropertyChanged("PlayerLabel");
            RaisePropertyChanged("DealerLabel");
            RaisePropertyChanged("PlayerScore");
            RaisePropertyChanged("DealerScore");
        }
        public void StartGame()
        {
            ResetData();
            _CardCounter = FULL_DECK;
            _CardPicker = new Random();     
            GameDeck = new GameDeck();
            _IsGameOn = true;           
            PlayerInstance = new PlayerVM(this);
            DealerInstance = new DealerVM(this);
            PlayerInstance.Hand.Add(Draw());
            PlayerInstance.Hand.Add(Draw());
            DealerInstance.Hand.Add(Draw());
            DealerInstance.Hand.Add(Draw());
            ///
            ///set up inital scores for
            ///initial hand
            foreach (var card in _PlayerInstance.Hand)
            {
                _PlayerScore += card.CardWorth;
            }
            foreach (var card in _DealerInstance.Hand)
            {
                _DealerScore += card.CardWorth;
            }
            RaisePropertyChanged("IsGameOn");
            RaisePropertyChanged("PlayerInstance");
            RaisePropertyChanged("DealerInstance");
            RaisePropertyChanged("PlayerScore");
            RaisePropertyChanged("DealerScore");
        }
        #endregion

        #region BlackJack Actions & Misc
        public Card Draw()
        {
            int cardIndex = _CardPicker.Next(0, 51);
            Card cardPicked = GameDeck.Deck.ElementAt(cardIndex);
            ///causing errors at the moment (3/22/16 4:59pm)
            ///because randomization is picking numbers that have been removed.
            ///_GameInstance.GameDeck.Deck.Remove(cardPicked); 
            _CardCounter = GameDeck.Deck.Count();
            RaisePropertyChanged("CardCounter");
            RaisePropertyChanged("PlayerInstance");
            RaisePropertyChanged("CardImagePath");
            return cardPicked;
        }

        public string TranslateCardNumber(int cardnumber)
        {
            switch (cardnumber)
            {
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                case 14:
                    return "Ace";
            }
            return string.Empty;
        }

        #endregion
    }

}
