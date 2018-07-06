using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void WordCount_ReturnZero()
    {
      //Arrange
      string newWord = "game";
      string newSentence = "Let's play.";
      RepeatCounter newCheck = new RepeatCounter(newWord, newSentence);
      int result = 0;
      //Act
      string expectedWord = newCheck.GetWord();
      int expectedResult = newCheck.GetWordCount();
      //Assert
      Assert.AreEqual(newWord, expectedWord);
      Assert.AreEqual(result, expectedResult);
    }
    [TestMethod]
    public void WordCount_ReturnOne()
    {
      //Arrange
      string newWord = "GAME";
      string newSentence = "Let's play a game.";
      RepeatCounter newCheck = new RepeatCounter(newWord, newSentence);
      int result = 1;
      //Act
      int expectedResult = newCheck.GetWordCount();
      //Assert
      Assert.AreEqual(result, expectedResult);
    }
    [TestMethod]
    public void WordCount_ReturnTwo()
    {
      //Arrange
      string newWord = "GaMe";
      string newSentence = "Let's play a GAME, called monopoly game.";
      RepeatCounter newCheck = new RepeatCounter(newWord, newSentence);
      int result = 2;
      //Act
      int expectedResult = newCheck.GetWordCount();
      //Assert
      Assert.AreEqual(result, expectedResult);
    }
  }
}
