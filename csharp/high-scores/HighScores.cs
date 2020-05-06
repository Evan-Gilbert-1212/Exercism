using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
  private readonly List<int> _list;

  public HighScores(List<int> list) => this._list = list;

  public List<int> Scores()
  {
    return this._list;
  }

  public int Latest()
  {
    return this._list.Last();
  }

  public int PersonalBest()
  {
    return this._list.Max();
  }

  public List<int> PersonalTopThree()
  {
    var max3 = new List<int>();

    for (var i = 1; i <= 3; i++)
    {
      if (this._list.Count > 0)
      {
        var maxScore = this._list.Max();
        max3.Add(maxScore);
        this._list.Remove(maxScore);
      }
    }

    return max3;
  }
}