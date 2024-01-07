// Task: Given an array of Player objects (an array of associative arrays in PHP) and an index (1-based), return the name of the chosen Player(name is a property of Player objects, e.g Player.name)

// Example:

// duck_duck_goose([a, b, c, d], 1) should return a.name
// duck_duck_goose([a, b, c, d], 5) should return a.name
// duck_duck_goose([a, b, c, d], 4) should return d.name

public class Kata
{
  public static string DuckDuckGoose(Player[] players, int goose)
  {
    return players[(goose-1) % players.Length].Name;
  }
}
public class Player 
{
  public string Name {get;set;}
  
  public Player (string name) 
  {
	  this.Name = name;
  }
}