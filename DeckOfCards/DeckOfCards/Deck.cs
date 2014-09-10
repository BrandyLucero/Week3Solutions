using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Deck
    {
        //Rank r = (Rank){};
        //Suit s = (Suit)8

        //define property list
        List<Card> cards { get; set; }
        //constructor
        public Deck()
        {
            this.cards = new List<Card>();
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    this.cards.Add(new Card((Suit)i, (Rank)j));
                }
            }    
        }
    }
}
