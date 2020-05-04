using System;
using System.Collections.Generic;

public static class ResistorColor
{
  public static int ColorCode(string color)
  {
    var colorCodes = new Dictionary<string, int> {
          {"black", 0},
          {"brown", 1},
          {"red", 2},
          {"orange", 3},
          {"yellow", 4},
          {"green", 5},
          {"blue", 6},
          {"violet", 7},
          {"grey", 8},
          {"white", 9}
        };

    int colorValue;

    colorCodes.TryGetValue(color, out colorValue);

    return colorValue;
  }

  public static string[] Colors()
  {
    return new string[10] {
      "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"
    };
  }
}