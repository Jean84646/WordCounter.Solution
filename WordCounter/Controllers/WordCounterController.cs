using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/WordCounter")]
    public ActionResult WordCounter()
    {
      return View();
    }
    [HttpGet("/WordCounter/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/WordCounter")]
    public ActionResult Create()
    {
      RepeatCounter newWord = new RepeatCounter(Request.Form["newWord"],Request.Form["newSentence"]);

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
      return View("WordCounter", count);
    }

    [HttpPost("/WordCounter/delete")]
    public ActionResult DeleteAll()
    {
      WordCounterObject.ClearAll();
      return View();
    }

  }
}
