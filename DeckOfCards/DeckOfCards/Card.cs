using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{

    public enum Suit 
        
    {
        heart = 1, diamond, spade, club //=4

    }

    public enum Rank
    {
        two = 2, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace //=14
    }

    class Card
    {

        //1. define our priorities for our card, suit and rank
        public Suit Suit {get; set;}
        public Rank Rank {get; set;}

        //2. create constructors for our properties
        public Card(Suit suit, Rank rank)
        {
            this.Suit = suit;
            this.Rank = rank;

        }
    }
}
