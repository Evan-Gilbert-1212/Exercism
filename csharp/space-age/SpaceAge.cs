using System;

public class SpaceAge
{
  public int ageInSeconds;

  public SpaceAge(int seconds)
  {
    ageInSeconds = seconds;
  }

  public double OnEarth()
  {
    return Math.Round(ageInSeconds / 60 / 60 / 24 / 365.25, 2);
  }

  public double OnMercury()
  {
    return Math.Round(OnEarth() / 0.2408467, 2);
  }

  public double OnVenus()
  {
    return Math.Round(ageInSeconds / 60 / 60 / 24 / 365.25 / 0.61519726, 2);
  }

  public double OnMars()
  {
    return Math.Round(OnEarth() / 1.8808158, 2);
  }

  public double OnJupiter()
  {
    return Math.Round(OnEarth() / 11.862615, 2);
  }

  public double OnSaturn()
  {
    return Math.Round(OnEarth() / 29.447498, 2);
  }

  public double OnUranus()
  {
    return Math.Round(OnEarth() / 84.016846, 2);
  }

  public double OnNeptune()
  {
    return Math.Round(OnEarth() / 164.79132, 2);
  }
}