namespace DotKeeps.Shared;

public class Formatters
{
  public static string CapitalizeFirstLetter(string input)
  {
    if (string.IsNullOrEmpty(input))
    {
      return input;
    }
    string lowerCaseInput = input.ToLower();
    char firstChar = char.ToUpper(lowerCaseInput[0]);
    string restOfString = lowerCaseInput[1..];
    return firstChar + restOfString;
  }
}
