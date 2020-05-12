using System;
using System.Collections.Generic;

public enum Allergen
{
  Eggs = 1,
  Peanuts = 2,
  Shellfish = 4,
  Strawberries = 8,
  Tomatoes = 16,
  Chocolate = 32,
  Pollen = 64,
  Cats = 128
}

public class Allergies
{
  public int AllergyScore;

  public Allergies(int mask)
  {
    AllergyScore = mask;
  }

  public bool IsAllergicTo(Allergen allergen)
  {
    switch (allergen)
    {
      case Allergen.Eggs:
        return (AllergyScore & (int)allergen) == 1;
      case Allergen.Peanuts:
        return (AllergyScore & (int)allergen) == 2;
      case Allergen.Shellfish:
        return (AllergyScore & (int)allergen) == 4;
      case Allergen.Strawberries:
        return (AllergyScore & (int)allergen) == 8;
      case Allergen.Tomatoes:
        return (AllergyScore & (int)allergen) == 16;
      case Allergen.Chocolate:
        return (AllergyScore & (int)allergen) == 32;
      case Allergen.Pollen:
        return (AllergyScore & (int)allergen) == 64;
      case Allergen.Cats:
        return (AllergyScore & (int)allergen) == 128;
      default:
        return false;
    }
  }

  public Allergen[] List()
  {
    //take the score and check for any allergies, return list of matching allergies
    List<Allergen> listofAllergies = new List<Allergen>();

    foreach (Allergen allergy in Enum.GetValues(typeof(Allergen)))
    {
      if (IsAllergicTo(allergy))
      {
        listofAllergies.Add(allergy);
      }
    }

    Allergen[] Allergies = listofAllergies.ToArray();

    return Allergies;
  }
}