using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void WordCount_ReturnZero()
    {
      //Arrange
      string word = "Game";
      string inputSentence = "Let's play.";
      RepeatCounter newWord = new RepeatCounter(word);
      int result = 0;
      //Act
      int expectedResult = newWord.WordCount(inputSentence);
      //Assert
      Assert.AreEqual(result, expectedResult);
    }
    [TestMethod]
    public void WordCount_ReturnOne()
    {
      //Arrange
      string word = "Game";
      string inputSentence = "Let's play a game.";
      RepeatCounter newWord = new RepeatCounter(word);
      int result = 1;
      //Act
      int expectedResult = newWord.WordCount(inputSentence);
      //Assert
      Assert.AreEqual(result, expectedResult);
    }
    [TestMethod]
    public void WordCount_ReturnTwo()
    {
      //Arrange
      string word = "Game";
      string inputSentence = "Let's play a GAME, called monopoly game.";
      RepeatCounter newWord = new RepeatCounter(word);
      int result = 2;
      //Act
      int expectedResult = newWord.WordCount(inputSentence);
      //Assert
      Assert.AreEqual(result, expectedResult);
    }
  }
}
