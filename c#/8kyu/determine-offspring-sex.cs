// If the sperm contains the X chromosome, return "Congratulations! You're going to have a daughter."; If the sperm contains the Y chromosome, return "Congratulations! You're going to have a son.";

public class Kata
{
  public static string ChromosomeCheck(string sperm)
  {
     return (sperm == "XY") ? "Congratulations! You're going to have a son." : "Congratulations! You're going to have a daughter.";
  }
}