using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string wordToBeCount;
    private string sentenceToBeCheck;

    public RepeatCounter(string word, string sentence)
    {
      wordToBeCount = word;
      sentenceToBeCheck = sentence;
    }
    public string GetWord()
    {
      return word;
    }
    public string GetSentence()
    {
      return sentence;
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
    
    public static void ClearAll()
    {
      newPlaces.Clear();
    }
  }
}
