using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string WordToBeCount;
    private string SentenceToBeCheck;
    private int Count = 0;
    private int Id;
    private static int lastId = 0;
    private static List<RepeatCounter> Matches = new List<RepeatCounter> {};

    public RepeatCounter(string word, string sentence)
    {
      WordToBeCount = word;
      SentenceToBeCheck = sentence;
      Matches.Add(this);
      Id = ++lastId;
      this.WordCount();
    }
    public string GetWord()
    {
      return WordToBeCount;
    }
    public string GetSentence()
    {
      return SentenceToBeCheck;
    }
    public int GetId()
    {
      return Id;
    }
    public static RepeatCounter Find(int searchId)
    {
      return Matches[searchId - 1];
    }
    public static List<RepeatCounter> GetAll()
    {
      return Matches;
    }
    public static void ClearAll()
    {
      Matches.Clear();
    }
    public int WordCount()
    {
      string[] arrayWords = SentenceToBeCheck.Split(' ', ',', '.');
      for (int i = 0; i < arrayWords.Length; i++)
      {
        if (WordToBeCount.ToUpper().Equals(arrayWords[i].ToUpper()))
        {
          Count += 1;
        }
      }
      return Count;
    }
    public int GetWordCount()
    {
      return Count;
    }
  }
}
