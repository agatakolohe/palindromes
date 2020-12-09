using System;
using System.Collections.Generic;

namespace Palindromes
{
  public class Words
  {
    public string TurnIntoArray(string word)
    {
      char[] letters = word.ToCharArray();
      Array.Reverse(letters);
      string reversedWord = new String(letters);
      return reversedWord;
    }
  }
}