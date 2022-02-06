using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class PokerDeck : Deck
    {
        public PokerDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCard> DealCard()
        {
            List<PlayingCard> output = new List<PlayingCard>();
            for (int i = 0; i < 5; i++)
            {
                output.Add(RequestCard());
            }
            return output;
        }
    }
}
