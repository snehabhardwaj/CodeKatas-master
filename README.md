# Poker Hand Ranking

## Overview

This project evaluates a poker hand and returns its highest-ranking classification based on standard poker rules.

The `RankHand()` method accepts a list of five cards and determines the strongest possible hand.

## Supported Hand Rankings

The following rankings are evaluated from highest to lowest:

| Rank | Description |
|--------|-------------|
| Royal Flush | A, K, Q, J, 10 of the same suit |
| Straight Flush | Five consecutive cards of the same suit |
| Four of a Kind | Four cards of the same rank |
| Full House | Three cards of one rank and two cards of another rank |
| Flush | Five cards of the same suit |
| Straight | Five consecutive cards |
| Three of a Kind | Three cards of the same rank |
| Two Pair | Two different pairs |
| One Pair | One pair of matching ranks |
| High Card | Highest-ranking card in the hand |

## Implementation Approach

The solution determines the hand ranking by:

1. Checking whether all cards belong to the same suit (Flush).
2. Checking whether the cards form a sequence (Straight).
3. Grouping cards by rank to identify pairs, three-of-a-kind, and four-of-a-kind combinations.
4. Evaluating hand rankings from highest to lowest priority.
5. Returning the highest matching hand rank.

## Example

### Input
var hand = new List<Card>
{
    new Card { Rank = Rank.Ace, Suit = Suit.Club },
    new Card { Rank = Rank.King, Suit = Suit.Club },
    new Card { Rank = Rank.Queen, Suit = Suit.Club },
    new Card { Rank = Rank.Jack, Suit = Suit.Club },
    new Card { Rank = Rank.Ten, Suit = Suit.Club }
};
