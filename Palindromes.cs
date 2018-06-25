using System;
using System.Collections.Generic;
class Palendrome
{
  public string _userString = "";
  public bool Spaghetti()
  {
    int i = 0;
    int j = _userString.Length - 1;
    while (i<j)
    {
      if (_userString[i] != _userString[j])
        return false;
      i++;
      j--;
    }
    return true;
  }
}
public class Program
{
  public static void Main()
  {
    Palendrome newPalendrome = new Palendrome();
    Console.WriteLine("Enter something");
    newPalendrome._userString = Console.ReadLine().ToLower();
    bool dog = newPalendrome.Spaghetti();
    Console.WriteLine(dog);
  }
}
