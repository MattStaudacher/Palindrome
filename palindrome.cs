using System;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    //Console.WriteLine("Input");

    PalindromeEasy easyP = new PalindromeEasy();
    easyP.Input();
    Console.WriteLine("Palindrome: "+easyP.IsPalindrome());

    // PalindromeHard palindrome = new PalindromeHard();
    // palindrome.GetUserInput();
    // palindrome.IsPalindrome();
  }
}

class PalindromeEasy
{
  private string _palindrome;

  public PalindromeEasy()
  {
    _palindrome = "";
  }

  public void Input()
  {
    Console.WriteLine("Input: ");
    _palindrome = Console.ReadLine().Trim();
  }

  public bool IsPalindrome()
  {
    char[] pArray = _palindrome.ToCharArray();
    char[] pReverse = _palindrome.ToCharArray();
    Array.Reverse(pReverse);
    string s1 = new string(pArray);
    string s2 = new string(pReverse);
    return (s1 == s2);
  }
}




class PalindromeHard
{
  private string _palindrome;

  public PalindromeHard()
  {
    _palindrome = "";
  }

  public PalindromeHard(string palindrome)
  {
    _palindrome = palindrome;
  }

  public void GetUserInput()
  {
    Console.WriteLine("Input: ");
    _palindrome = Console.ReadLine().Trim();
  }

  private bool CompareEnds()
  {
    return (_palindrome[0] == _palindrome[_palindrome.Length-1]);
  }

  private void RemoveEnds()
  {
    if(_palindrome.Length >= 2)
    {
      _palindrome = _palindrome.Remove(0,1);
      _palindrome = _palindrome.Remove(_palindrome.Length-1,1);
    }
  }

  private void Output()
  {
    Console.WriteLine(_palindrome);
  }

  public void IsPalindrome()
  {
    bool isPalindrome = true;
    while(isPalindrome && _palindrome.Length > 1)
    {
      isPalindrome = CompareEnds();
      if(isPalindrome)
      {
        RemoveEnds();
      }
      Output();
    }
    Console.WriteLine("Palindrome: "+isPalindrome);
  }

}
