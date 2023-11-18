// You get any card as an argument. Your task is to return the suit of this card (in lowercase).

// Our deck (is preloaded):

// string[] Deck =
// {
//     "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣",
//     "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦",
//     "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥",
//     "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠"
// };

// DefineSuit("3♣") -> return "clubs"
// DefineSuit("3♦") -> return "diamonds"
// DefineSuit("3♥") -> return "hearts"
// DefineSuit("3♠") -> return "spades"

namespace Solution
{
  public partial class Kata
  {
    public static string DefineSuit(string card)
    {
      return card[^1] switch {
        '♣' => "clubs",
        '♦' => "diamonds",
        '♥' => "hearts",
        '♠' => "spades"
      };
    }
  }
}