using System.Collections.Generic;
using HearthDb;
using System.Linq;

namespace HighStar.Core.Entities
{
    public class Deck
    {
        public List<HSCard> Cards { get; private set; }

        public Deck()
        {
            Cards = new List<HSCard>(30);
        }

        public void AddCard(Card card)
        {
            var hsCard = new HSCard(card);
            Cards.Add(hsCard);
        }

        public bool Contains(Card card)
        {
            var hsCard = new HSCard(card);
            return Cards.Contains(hsCard);
        }
    }
}
