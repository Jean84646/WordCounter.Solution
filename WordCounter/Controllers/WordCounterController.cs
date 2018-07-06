using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/WordCounter")]
    public ActionResult Index()
    {
      List<RepeatCounter> newMatches = RepeatCounter.GetAll();
      return View(newMatches);
    }
    [HttpGet("/WordCounter/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/WordCounter")]
    public ActionResult Create(string newWord, string newSentence)
    {
      RepeatCounter newCheck = new RepeatCounter(newWord, newSentence);
      return RedirectToAction("Index");
    }
    [HttpPost("/WordCounter/delete")]
    public ActionResult DeleteAll()
    {
      RepeatCounter.ClearAll();
      return RedirectToAction("CreateForm");
    }
  }
}
