using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHandRanking
{
    public class PokerHandRanking
    {
        public string RankHand(List<Card> hand)
        {

            bool isFlush = hand.All(c => c.Suit == hand.First().Suit);
            bool isStraight = IsStraight(hand);
            var rankGroups = hand.GroupBy(c => c.Rank)
                                .OrderByDescending(g => g.Count())
                                .ToList();

            if (isFlush && isStraight)
            {
                var ranks = hand.Select(c => c.Rank).ToList();

                if (ranks.Contains(Rank.Ace) && ranks.Contains(Rank.King) && ranks.Contains(Rank.Queen) && ranks.Contains(Rank.Jack) && ranks.Contains(Rank.Ten))
                {
                    return "Royal Flush";
                }

                return "Straight Flush";
            }
            if (rankGroups[0].Count() == 4)
                return "Four of a Kind";

            if (rankGroups[0].Count() == 3 && rankGroups[1].Count() == 2)
                return "Full House";

            if (isFlush)
                return "Flush";

            if (isStraight)
                return "Straight";

            if (rankGroups[0].Count() == 3)
                return "Three of a Kind";

            if (rankGroups[0].Count() == 2 && rankGroups[1].Count() == 2)
                return "Two Pair";

            if (rankGroups[0].Count() == 2)
                return "One Pair";

            return GetHighCard(hand);


        }

        private bool IsStraight(List<Card> hand)
        {
            var ranks = hand.Select(c => c.Rank).Distinct().OrderBy(r => r).ToList();

            if (ranks.Count != 5)
                return false;

            // Special case: 10 J Q K A
            if (ranks.Contains(Rank.Ten) && ranks.Contains(Rank.Jack) && ranks.Contains(Rank.Queen) && ranks.Contains(Rank.King) && ranks.Contains(Rank.Ace))
            {
                return true;
            }

            for (int i = 1; i < ranks.Count; i++)
            {
                if ((int)ranks[i] - (int)ranks[i - 1] != 1)
                    return false;
            }

            return true;
        }

        private string GetHighCard(List<Card> hand)
        {
            if (hand.Any(c => c.Rank == Rank.Ace))
                return "Ace";

            return hand.Max(c => c.Rank).ToString();
        }
    }
}
