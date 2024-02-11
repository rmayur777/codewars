// Create a combat function that takes the player's current health and the amount of damage recieved, and returns the player's new health. Health can't be less than 0.

using System;

public static class Game
{
  public static float Combat(float health, float damage)
  {
  return (health >= damage) ? health - damage : 0;
  }
}