using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
  public string Name { get; set; }

  static List<string> robotNames { get; set; } = new List<string>();

  public Robot()
  {
    GenerateRobotName();
  }

  public void Reset()
  {
    GenerateRobotName();
  }

  public void GenerateRobotName()
  {
    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    var ints = "0123456789";
    var random = new Random();

    var nameBuilder = new StringBuilder();

    nameBuilder.Append(chars[random.Next(chars.Length)])
               .Append(chars[random.Next(chars.Length)])
               .Append(ints[random.Next(ints.Length)])
               .Append(ints[random.Next(ints.Length)])
               .Append(ints[random.Next(ints.Length)]);

    while (robotNames.Contains(nameBuilder.ToString()))
    {
      nameBuilder.Clear();

      nameBuilder.Append(chars[random.Next(chars.Length)])
                 .Append(chars[random.Next(chars.Length)])
                 .Append(ints[random.Next(ints.Length)])
                 .Append(ints[random.Next(ints.Length)])
                 .Append(ints[random.Next(ints.Length)]);
    }

    Name = nameBuilder.ToString();

    robotNames.Add(Name);
  }
}