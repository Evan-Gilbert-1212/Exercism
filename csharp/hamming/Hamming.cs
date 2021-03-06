using System;

public static class Hamming
{
  public static int Distance(string firstStrand, string secondStrand)
  {
    if (firstStrand.Length != secondStrand.Length)
    {
      throw new ArgumentException();
    }
    else
    {
      var mismatches = 0;

      for (var i = 0; i < firstStrand.Length; i++)
      {
        if (firstStrand[i] != secondStrand[i])
          mismatches++;
      }

      return mismatches;
    }
  }
}