// Selection Grid Layout in text:

// | Ryu  | E.Honda | Blanka  | Guile   | Balrog | Vega    |
// | Ken  | Chun Li | Zangief | Dhalsim | Sagat  | M.Bison |

// Input

//     the list of game characters in a 2x6 grid;
//     the initial position of the selection cursor (top-left is (0,0));
//     a list of moves of the selection cursor (which are up, down, left, right);

// Output

//     the list of characters who have been hovered by the selection cursor after all the moves (ordered and with repetition, all the ones after a move, whether successful or not, see tests);

// Rules

// Selection cursor is circular horizontally but not vertically!

// As you might remember from the game, the selection cursor rotates horizontally but not vertically; that means that if I'm in the leftmost and I try to go left again I'll get to the rightmost (examples: from Ryu to Vega, from Ken to M.Bison) and vice versa from rightmost to leftmost.

// Instead, if I try to go further up from the upmost or further down from the downmost, I'll just stay where I am located 

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
  {
    var results = new List<string>();
    var row = 0;
    var col = 0;
    
    foreach (var s in moves) {
      switch (s) {
        case "up": row -= 1;
          break;
        case "down": row += 1;
          break;
        case "left": col -= 1;
          break;
        case "right": col += 1;
          break;
      }
      if (row < 0) row = 0;
      if (row == fighters.Length) row--;
      if (col == fighters[0].Length) col = 0;
      if (col == -1) col = fighters[0].Length - 1;
      
      results.Add(fighters[row][col]);
    }
      
    return results.ToArray();
  }  
}