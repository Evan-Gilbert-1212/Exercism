using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
  public static IDictionary<char, int> Count(string sequence)
  {
    var nucleotides = new Dictionary<char, int>(){
          {'A', 0},
          {'G', 0},
          {'C', 0},
          {'T', 0}
        };

    for (var i = 0; i < sequence.Length; i++)
    {
      if (nucleotides.ContainsKey(sequence[i]))
        nucleotides[sequence[i]]++;
      else
        throw new ArgumentException();
    }

    return nucleotides;
  }
}