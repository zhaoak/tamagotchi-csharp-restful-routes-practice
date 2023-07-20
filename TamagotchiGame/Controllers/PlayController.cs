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
}
