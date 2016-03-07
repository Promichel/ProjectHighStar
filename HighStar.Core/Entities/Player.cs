using System.Collections.Generic;

namespace HighStar.Core.Entities
{
    public class Player
    {
        public List<HSCard> CardsInDeck { get; private set; }
        public List<HSCard> CardsInHand { get; private set; }

        public bool UsedHeroPower => _usedHeroPower;
        private bool _usedHeroPower;

        public int MaxMana { get; private set; }
        public int CurrentMana { get; private set; }
    }
}
