using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string wordToBeCount;
    private string sentenceToBeCheck;
    private int id;
    private static int lastId = 0;
    private static List<RepeatCounter> matches = new List<RepeatCounter> {};

    public RepeatCounter(string word, string sentence)
    {
      wordToBeCount = word;
      sentenceToBeCheck = sentence;
      matches.Add(this);
      id = ++lastId;
    }
    public string GetWord()
    {
      return wordToBeCount;
    }
    public string GetSentence()
    {
      return sentenceToBeCheck;
    }
    public int GetId()
    {
      return id;
    }
    public static RepeatCounter Find(int searchId)
    {
      return matches[searchId - 1];
    }
    public static List<RepeatCounter> GetAll()
    {
      return matches;
    }
    public static void ClearAll()
    {
      matches.Clear();
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
}
