using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace BlackJack_V1._1.DataModels
{
    public class GameDeck
    {
        public ObservableCollection<Card> Deck { get; set; }
        public GameDeck()
        {
            Deck = new ObservableCollection<Card>();
            GetDeck();
        }
        public void GetDeck()
        {
            ///
            ///Our 52 card deck
            ///Clubs
            Deck.Add(new Card() { CardNumber = 2, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath="/Images/2_Clubs.png", CardWorth=2 });
            Deck.Add(new Card() { CardNumber = 3, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath = "/Images/3_Clubs.png", CardWorth = 3 });
            Deck.Add(new Card() { CardNumber = 4, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath = "/Images/4_Clubs.png", CardWorth = 4 });
            Deck.Add(new Card() { CardNumber = 5, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath = "/Images/5_Clubs.png", CardWorth = 5 });
            Deck.Add(new Card() { CardNumber = 6, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath = "/Images/6_Clubs.png", CardWorth = 6 });
            Deck.Add(new Card() { CardNumber = 7, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath = "/Images/7_Clubs.png", CardWorth = 7 });
            Deck.Add(new Card() { CardNumber = 8, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath = "/Images/8_Clubs.png", CardWorth = 8 });
            Deck.Add(new Card() { CardNumber = 9, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath = "/Images/9_Clubs.png", CardWorth = 9 });
            Deck.Add(new Card() { CardNumber = 10, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath = "/Images/10_Clubs.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 11, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath = "/Images/Jack_Clubs.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 12, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath = "/Images/Queen_Clubs.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 13, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath = "/Images/King_Clubs.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 14, CardSuit = GlobalEnums.CardSuit.Club, CardImagePath = "/Images/Ace_Clubs.png", CardWorth = 11 ,AlternateWorth = 1});
            ///
            ///Diamonds
            ///
            Deck.Add(new Card() { CardNumber = 2, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/2_Diamonds.png", CardWorth = 2 });
            Deck.Add(new Card() { CardNumber = 3, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/3_Diamonds.png", CardWorth = 3 });
            Deck.Add(new Card() { CardNumber = 4, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/4_Diamonds.png", CardWorth=4  });
            Deck.Add(new Card() { CardNumber = 5, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/5_Diamonds.png", CardWorth = 5 });
            Deck.Add(new Card() { CardNumber = 6, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/6_Diamonds.png", CardWorth = 6 });
            Deck.Add(new Card() { CardNumber = 7, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/7_Diamonds.png", CardWorth = 7 });
            Deck.Add(new Card() { CardNumber = 8, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/8_Diamonds.png", CardWorth = 8 });
            Deck.Add(new Card() { CardNumber = 9, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/9_Diamonds.png", CardWorth = 9 });
            Deck.Add(new Card() { CardNumber = 10, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/10_Diamonds.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 11, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/Jack_Diamonds.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 12, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/Queen_Diamonds.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 13, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/King_Diamonds.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 14, CardSuit = GlobalEnums.CardSuit.Diamond, CardImagePath = "/Images/Ace_Diamonds.png", CardWorth = 11,AlternateWorth = 1 });
            ///
            ///Hearts
            ///
            Deck.Add(new Card() { CardNumber = 2, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/2_Hearts.png", CardWorth = 2 });
            Deck.Add(new Card() { CardNumber = 3, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/3_Hearts.png", CardWorth = 3 });
            Deck.Add(new Card() { CardNumber = 4, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/4_Hearts.png", CardWorth = 4 });
            Deck.Add(new Card() { CardNumber = 5, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/5_Hearts.png", CardWorth = 5 });
            Deck.Add(new Card() { CardNumber = 6, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/6_Hearts.png", CardWorth = 6 });
            Deck.Add(new Card() { CardNumber = 7, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/7_Hearts.png", CardWorth = 7 });
            Deck.Add(new Card() { CardNumber = 8, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/8_Hearts.png", CardWorth = 8 });
            Deck.Add(new Card() { CardNumber = 9, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/9_Hearts.png", CardWorth = 9 });
            Deck.Add(new Card() { CardNumber = 10, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/10_Hearts.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 11, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/Jack_Hearts.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 12, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/Queen_Hearts.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 13, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/King_Hearts.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 14, CardSuit = GlobalEnums.CardSuit.Heart, CardImagePath = "/Images/Ace_Hearts.png", CardWorth = 11, AlternateWorth = 1 });
            ///
            ///Spades
            ///
            Deck.Add(new Card() { CardNumber = 2, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/2_Spades.png", CardWorth = 2 });
            Deck.Add(new Card() { CardNumber = 3, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/3_Spades.png", CardWorth = 3 });
            Deck.Add(new Card() { CardNumber = 4, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/4_Spades.png", CardWorth = 4 });
            Deck.Add(new Card() { CardNumber = 5, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/5_Spades.png", CardWorth = 5 });
            Deck.Add(new Card() { CardNumber = 6, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/6_Spades.png", CardWorth = 6});
            Deck.Add(new Card() { CardNumber = 7, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/7_Spades.png", CardWorth = 7 });
            Deck.Add(new Card() { CardNumber = 8, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/8_Spades.png", CardWorth = 8 });
            Deck.Add(new Card() { CardNumber = 9, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/9_Spades.png", CardWorth = 9 });
            Deck.Add(new Card() { CardNumber = 10, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/10_Spades.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 11, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/Jack_Spades.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 12, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/Queen_Spades.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 13, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/King_Spades.png", CardWorth = 10 });
            Deck.Add(new Card() { CardNumber = 14, CardSuit = GlobalEnums.CardSuit.Spade, CardImagePath = "/Images/Ace_Spades.png", CardWorth = 11, AlternateWorth = 1 });
            ///
            ///add all card index values for retrieval because I was too lazy to type indexes in lol
            ///
            for(int i = 0; i <= 51; i++)
            {
                Deck.ElementAt(i).CardIndex = i;
            }
        }
    }

}
