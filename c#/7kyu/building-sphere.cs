// Arguments for the constructor

// radius -> integer
// mass -> integer

// Methods to be defined

// GetRadius()       =>  radius of the Sphere
// GetMass()         =>  mass of the Sphere
// GetVolume()       =>  volume of the Sphere (a double rounded to 5 place after the decimal)
// GetSurfaceArea()  =>  surface area of the Sphere (a double rounded to 5 place after the decimal)
// GetDensity()      =>  density of the Sphere (a double rounded to 5 place after the decimal)

using System;

public class Sphere
{
	private readonly int _radius;
  private readonly int _mass; 
  
  public Sphere(int radius, int mass)
  {
    _radius = radius;
    _mass = mass;
  }
  
  public int GetRadius()=> _radius;
  public int GetMass()=> _mass;
  public double GetVolume()=> Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3), 5);
  public double GetSurfaceArea()=> Math.Round(4 * Math.PI * _radius * _radius, 5);
  public double GetDensity()=> Math.Round(_mass/Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3), 5),5);
  
}