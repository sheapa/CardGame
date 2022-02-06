using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public abstract class Deck
    {

        protected List<PlayingCard> fullDeck = new List<PlayingCard>();
        protected List<PlayingCard> drawPile = new List<PlayingCard>();
        protected List<PlayingCard> discardPile = new List<PlayingCard>();
        public void CreateDeck()
        {
            fullDeck.Clear();
            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCard {Suit = (Enums.CardSuit) suit, Value = (Enums.CardValue) val});

                ;
                }
            }

        }

        public virtual void ShuffleDeck()
        {
            //psuedo random
            var rnd = new Random();
            drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();

        }

        public abstract List<PlayingCard> DealCard();

        public virtual PlayingCard RequestCard()
        {
            PlayingCard output = drawPile.Take(1).First();
            drawPile.Remove(output);
            return output;
        }
    }
}
