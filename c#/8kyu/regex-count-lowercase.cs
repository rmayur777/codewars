// Your task is simply to count the total number of lowercase letters in a string.

public class Kata
{
  public static int LowercaseCountCheck(string s)
  {
    int count = 0;
    for(int i=0; i<s.Length; i++){
      if (char.IsLower(s[i])){
        count ++;
      }
    }
    return count;
  }
}