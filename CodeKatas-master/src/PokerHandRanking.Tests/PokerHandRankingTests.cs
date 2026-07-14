using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerHandRanking.Tests
{
    [TestClass]
    public class PokerHandRankingTests
    {
        private PokerHandRanking pokerHandRanking;

        [TestInitialize]
        public void TestInitialize()
        {
            pokerHandRanking = new PokerHandRanking();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            pokerHandRanking = null;
        }

        [TestMethod]
        public void PokerHandRanking_returns_royal_flush()
        {
            var hand = new List<Card>()
            {
                new Card() { Rank = Rank.Ace, Suit = Suit.Club },
                new Card() { Rank = Rank.King, Suit = Suit.Club },
                new Card() { Rank = Rank.Queen, Suit = Suit.Club },
                new Card() { Rank = Rank.Jack, Suit = Suit.Club },
                new Card() { Rank = Rank.Ten, Suit = Suit.Club }
            };

            var result = pokerHandRanking.RankHand(hand);

            Assert.AreEqual("Royal Flush", result);
        }

        [TestMethod]
        public void PokerHandRanking_returns_straight()
        {
            var hand = new List<Card>()
             {
                 new Card() { Rank = Rank.Nine, Suit = Suit.Club },
                 new Card() { Rank = Rank.Eight, Suit = Suit.Heart },
                 new Card() { Rank = Rank.Seven, Suit = Suit.Spade },
                 new Card() { Rank = Rank.Six, Suit = Suit.Diamond },
                 new Card() { Rank = Rank.Five, Suit = Suit.Club }
             };

            var result = pokerHandRanking.RankHand(hand);

            Assert.AreEqual("Straight", result);
        }
        [TestMethod]
        public void PokerHandRanking_returns_straight_flush()
        {
            var hand = new List<Card>()
             {
                 new Card() { Rank = Rank.Nine, Suit = Suit.Heart },
                 new Card() { Rank = Rank.Eight, Suit = Suit.Heart },
                 new Card() { Rank = Rank.Seven, Suit = Suit.Heart },
                 new Card() { Rank = Rank.Six, Suit = Suit.Heart },
                 new Card() { Rank = Rank.Five, Suit = Suit.Heart }
             };

            var result = pokerHandRanking.RankHand(hand);

            Assert.AreEqual("Straight Flush", result);
        }

        [TestMethod]
        public void PokerHandRanking_returns_four_of_a_kind()
        {
            var hand = new List<Card>()
             {
                 new Card() { Rank = Rank.King, Suit = Suit.Club },
                 new Card() { Rank = Rank.King, Suit = Suit.Heart },
                 new Card() { Rank = Rank.King, Suit = Suit.Spade },
                 new Card() { Rank = Rank.King, Suit = Suit.Diamond },
                 new Card() { Rank = Rank.Two, Suit = Suit.Club }
             };

            var result = pokerHandRanking.RankHand(hand);

            Assert.AreEqual("Four of a Kind", result);
        }

        [TestMethod]
        public void PokerHandRanking_returns_full_house()
        {
            var hand = new List<Card>()
         {
             new Card() { Rank = Rank.King, Suit = Suit.Club },
             new Card() { Rank = Rank.King, Suit = Suit.Heart },
             new Card() { Rank = Rank.King, Suit = Suit.Spade },
             new Card() { Rank = Rank.Two, Suit = Suit.Diamond },
             new Card() { Rank = Rank.Two, Suit = Suit.Club }
         };

            var result = pokerHandRanking.RankHand(hand);

            Assert.AreEqual("Full House", result);
        }
        [TestMethod]
        public void PokerHandRanking_returns_flush()
        {
            var hand = new List<Card>()
         {
             new Card() { Rank = Rank.King, Suit = Suit.Club },
             new Card() { Rank = Rank.Nine, Suit = Suit.Club },
             new Card() { Rank = Rank.Seven, Suit = Suit.Club },
             new Card() { Rank = Rank.Four, Suit = Suit.Club },
             new Card() { Rank = Rank.Two, Suit = Suit.Club }
         };

            var result = pokerHandRanking.RankHand(hand);

            Assert.AreEqual("Flush", result);
        }
        [TestMethod]
        public void PokerHandRanking_returns_three_of_a_kind()
        {
            var hand = new List<Card>()
             {
                 new Card() { Rank = Rank.King, Suit = Suit.Club },
                 new Card() { Rank = Rank.King, Suit = Suit.Heart },
                 new Card() { Rank = Rank.King, Suit = Suit.Spade },
                 new Card() { Rank = Rank.Four, Suit = Suit.Diamond },
                 new Card() { Rank = Rank.Two, Suit = Suit.Club }
             };

            var result = pokerHandRanking.RankHand(hand);

            Assert.AreEqual("Three of a Kind", result);
        }
        [TestMethod]
        public void PokerHandRanking_returns_two_pair()
        {
            var hand = new List<Card>()
             {
                 new Card() { Rank = Rank.King, Suit = Suit.Club },
                 new Card() { Rank = Rank.King, Suit = Suit.Heart },
                 new Card() { Rank = Rank.Four, Suit = Suit.Spade },
                 new Card() { Rank = Rank.Four, Suit = Suit.Diamond },
                 new Card() { Rank = Rank.Two, Suit = Suit.Club }
             };

            var result = pokerHandRanking.RankHand(hand);

            Assert.AreEqual("Two Pair", result);
        }
        [TestMethod]
        public void PokerHandRanking_returns_one_pair()
        {
            var hand = new List<Card>()
             {
                 new Card() { Rank = Rank.King, Suit = Suit.Club },
                 new Card() { Rank = Rank.King, Suit = Suit.Heart },
                 new Card() { Rank = Rank.Seven, Suit = Suit.Spade },
                 new Card() { Rank = Rank.Four, Suit = Suit.Diamond },
                 new Card() { Rank = Rank.Two, Suit = Suit.Club }
             };

            var result = pokerHandRanking.RankHand(hand);

            Assert.AreEqual("One Pair", result);
        }
        [TestMethod]
        public void PokerHandRanking_returns_high_card()
        {
            var hand = new List<Card>()
             {
                 new Card() { Rank = Rank.Ace, Suit = Suit.Club },
                 new Card() { Rank = Rank.Nine, Suit = Suit.Heart },
                 new Card() { Rank = Rank.Seven, Suit = Suit.Spade },
                 new Card() { Rank = Rank.Four, Suit = Suit.Diamond },
                 new Card() { Rank = Rank.Two, Suit = Suit.Heart }
             };

            var result = pokerHandRanking.RankHand(hand);

            Assert.AreEqual("Ace", result);
        }

    }
}
