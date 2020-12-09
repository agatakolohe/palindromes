using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class WordsTests
  {
    [TestMethod]
    public void IsWordsPalindrome_TurnStringIntoArray_True()
    {
      Words testWords = new Words();
      string test = "helb";
      Assert.AreEqual(test, testWords.TurnIntoArray("bleh"));
    }    
  }
}
