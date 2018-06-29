using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string wordToBeCount;

    public RepeatCounter(string word)
    {
      wordToBeCount = word;
    }
    public int WordCount(string inputSentence)
    {
      int count = 0;
      string[] arrayWords = inputSentence.Split(' ', ',', '.');
      for (int i = 0; i < arrayWords.Length; i++)
      {
        if (wordToBeCount.ToUpper().Equals(arrayWords[i].ToUpper()))
        {
          count += 1;
        }
      }
      return count;
    }
  }
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a sentence:");
      string inputSentence = Console.ReadLine();
      Console.WriteLine("Enter the word to be check:");
      string inputWord = Console.ReadLine();
      RepeatCounter newWord = new RepeatCounter(inputWord);
      int result = newWord.WordCount(inputSentence);
      Console.WriteLine("Count = " + result);
      Console.WriteLine("Would you like to check another sentence? (Y/N)");
      string replay = Console.ReadLine();
      if(replay == "Y" || replay == "y")
      {
        Main();
      }
    }
  }
}
