using Microsoft.AspNetCore.Mvc;

namespace QueenAttack.Controllers
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