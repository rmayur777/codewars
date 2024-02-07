// Finish the uefaEuro2016() function so it return string just like in the examples below:

// uefaEuro2016(['Germany', 'Ukraine'],[2, 0]) // "At match Germany - Ukraine, Germany won!"
// uefaEuro2016(['Belgium', 'Italy'],[0, 2]) // "At match Belgium - Italy, Italy won!"
// uefaEuro2016(['Portugal', 'Iceland'],[1, 1]) // "At match Portugal - Iceland, teams played draw."

using System.Linq;

public class Kata
{
  public static string UefaEuro2016(string[] teams, int[] scores)
  {
    if (scores[0] == scores[1])
        return $"At match {teams[0]} - {teams[1]}, teams played draw.";

      var winningIndex = scores.ToList().IndexOf(scores.Max());
      return $"At match {teams[0]} - {teams[1]}, {teams[winningIndex]} won!";
  }
}