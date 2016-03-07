using HearthDb;
using HighStar.Core.Entities;
using NUnit.Framework;

namespace HighStar.Core.Test
{
    [TestFixture]
    public class DeckTest
    {

        [Test]
        public void CreateDeckTest()
        {
            var deck = new Deck();
            deck.AddCard(Cards.Collectible[CardIds.Collectible.Warlock.Doomguard]);
            Assert.True(deck.Contains(Cards.Collectible[CardIds.Collectible.Warlock.Doomguard]));
            Assert.False(deck.Contains(Cards.Collectible[CardIds.Collectible.Warlock.BaneOfDoom]));
        }

    }
}
