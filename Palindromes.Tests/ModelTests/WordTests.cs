using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace Palindromes.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void ReverseWord_ReversesWord_String()
    {
      Word testWord = new Word();
      string test = "drow";
      Assert.AreEqual(test, testWord.ReverseWord("word"));
    }    

    [TestMethod]
    public void IsPalindrome_CheckIfPalindrome_True()
    {
      Word testWord = new Word();
      Assert.AreEqual(true, testWord.IsPalindrome("racecar", "racecar"));
    }
  }
}
