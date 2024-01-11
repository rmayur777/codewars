// Your Quark class should allow you to create quarks of any valid color ("red", "blue", and "green") and any valid flavor ('up', 'down', 'strange', 'charm', 'top', and 'bottom').

// Every quark has the same baryon_number (BaryonNumber in C#): 1/3.

// Every quark should have an .interact() (.Interact() in C#) method that allows any quark to interact with another quark via the strong force. When two quarks interact they exchange colors.

public class Quark
{
  public string Color;
  public string Flavor;

  public Quark(string color, string flavor)
  {
      Color = color;
      Flavor = flavor;
  }

  public double BaryonNumber => 1 / 3d;
  public void Interact(Quark q) => (Color, q.Color) = (q.Color, Color);
}