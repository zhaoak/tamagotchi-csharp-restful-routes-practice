using Microsoft.AspNetCore.Mvc;

namespace TamagotchiGame.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
