using System.Collections.Generic;
using HighStar.Core.Entities;

namespace HighStar.Core
{
    public class Game
    {
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        public List<HSCard> CardsOnBoard { get; private set; }
        
         
    }
}
