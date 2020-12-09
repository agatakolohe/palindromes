using System;
using System.Collections.Generic;

namespace Palindromes.Models
{
  public class Word
  {
    public string ReverseWord(string word)
    {
      char[] letters = word.ToCharArray();
      Array.Reverse(letters);
      string reversedWord = new String(letters);
      return reversedWord;
    }

    public bool IsPalindrome(string word, string reversedWord)
    {
      if (word == reversedWord)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
  }
}