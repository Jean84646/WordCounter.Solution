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
    public void SetWord(string newWord)
    {
      word = newWord;
    }
    public string GetSentence()
    {
      return sentence;
    }
    public void SetSentence(int newSentence)
    {
      sentence = newSentence;
    }
    public static void ClearAll()
    {
      newPlaces.Clear();
    }
  }
}
