using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BlackJack_V1._1.DataModels;
using System.Windows.Controls;

namespace BlackJack_V1._1.DataModels
{
    public class Card
    {
        public Card()
        {
            FaceUp = true;
        }
        public int CardIndex { get; set; }
        public int AlternateWorth { get; set; }
        public string CardImagePath { get; set; }
        public int CardWorth { get; set; }       
        public bool FaceUp { get; set; }
        public GlobalEnums.CardSuit CardSuit { get; set; }
        public int CardNumber { get; set; }
    }
}
