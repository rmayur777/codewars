// Imagine you are creating a game where the user has to guess the correct number. But there is a limit of how many guesses the user can do.

//     If the user tries to guess more than the limit, the function should throw an error.
//     If the user guess is right it should return true.
//     If the user guess is wrong it should return false and lose a life.

using System;

public class Guesser
{
    private int Number;
    private int Lives;

    public Guesser(int number, int lives)
    {
        Number = number;
        Lives = lives;
    }

    public bool Guess(int n)
    {
        if (Lives < 1) throw new Exception("You gone!");
        
        if (n == Number) return true;
        
        --Lives;
        return false;
    }
}