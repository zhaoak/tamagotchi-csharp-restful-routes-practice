using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TamagotchiGame.Models;

namespace TamagotchiGame.Controllers;

public class PlayController : Controller
{
  // main game page -- view all tamagotchis here
  [HttpGet("/play")]
  public ActionResult Index()
  {
    List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
    return View(allTamagotchis);
  }

  // adopt a new tamagotchi page
  [HttpGet("/play/new")]
  public ActionResult NewPet()
  {
    return View();
  }

  // new tamagotchis POST-ed here
  [HttpPost("/play")]
  public ActionResult Adopt(string newPetName)
  {
    Tamagotchi newPet = new Tamagotchi(newPetName);
    return RedirectToAction("Index");
  }

  // detail page for individual tamagotchis
  [HttpGet("/play/{id}")]
  public ActionResult Show(int id)
  {
    Tamagotchi foundPet = Tamagotchi.Find(id);
    return View(foundPet);
  }

  // feeding tamagotchis POSTs to here
  [HttpPost("/play/{id}/feed")]
  public ActionResult Feed(int id)
  {
    Tamagotchi.Feed(id);
    return RedirectToAction("Index");
  }

  // abandonment confirmation page
  [HttpGet("/play/{id}/abandon")]
  public ActionResult Abandon(int id)
  {
    return View(Tamagotchi.Find(id));
  }

  // abandoning tamagotchi POSTs to here
  [HttpPost("/play/{id}/abandon")]
  public ActionResult AbandonConfirmed(int id)
  {
    Tamagotchi.Abandon(id);
    return RedirectToAction("Index");
  }
}
