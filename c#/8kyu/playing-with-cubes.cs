// You already implemented a Cube class, but now we need your help again! I'm talking about constructors. We don't have one. Let's code two: One taking an integer and one handling no given arguments!

// Also we got a problem with negative values. Correct the code so negative values will be switched to positive ones!

// The constructor taking no arguments should assign 0 to Cube's Side property.

public class Cube
{
  private int Side;
  
  //This cube needs your help. 
  //Define a constructor which takes one integer and assignes its value to 'Side'
  public Cube(int s)
  {
    SetSide(s);
  }
  
  public Cube()
    : this(0)
  {
    
  }
  public int GetSide()
  {
    return Side;
  }
  
  public void SetSide(int s)
  {
    Side = System.Math.Abs(s);
  }
}