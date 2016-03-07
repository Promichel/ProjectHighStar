using System;
using HearthDb;

namespace HighStar.Core.Entities
{
    public class HSCard
    {
        public Card WrappedCard => _wrappedCard;
        private Card _wrappedCard;

        public HSCard(Card card)
        {
            _wrappedCard = card;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Card))
            {
                var card = obj as Card;
                return card.Id.Equals(_wrappedCard.Id);
            }

            if (obj.GetType() == typeof(HSCard))
            {
                var card = obj as HSCard;
                return card.WrappedCard.Id.Equals(_wrappedCard.Id);
            }

            return false;
        }
    }
}