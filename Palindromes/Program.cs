using System;
using Palindromes.Models;

public class Program
{
  public static void Main()
  {
  Word userWord = new Word();
   Console.WriteLine("Enter a word to see if it is a palindrome!");
   string input = Console.ReadLine();
   string inputReversed = userWord.ReverseWord(input);
   Console.WriteLine(userWord.IsPalindrome(input, inputReversed));
  }
}