// Since Nessie is a master of disguise, the only way accurately tell is to look for the phrase "tree fiddy". Since you are tired of being grifted by this monster, the time has come to code a solution for finding The Loch Ness Monster. Note that the phrase can also be written as "3.50" or "three fifty". Your function should return true if you're talking with The Loch Ness Moster, false otherwise. 

public static class Kata 
{
  public static bool IsLockNessMonster(string sentence) 
  {
    return sentence.Contains("3.50")
            || sentence.ToLower().Contains("tree fiddy")
            || sentence.ToLower().Contains("three fifty");
  }
}