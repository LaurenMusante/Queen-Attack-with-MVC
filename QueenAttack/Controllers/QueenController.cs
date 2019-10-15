using Microsoft.AspNetCore.Mvc;
using QueenAttack;

namespace QueenAttack.Controllers
{
  public class QueenController : Controller
  {

    [HttpGet("/queen/new")]
    public ActionResult New() //this will make the controller look for "New" under "Queen" in "Views". Changed from "Index" to "New" in order to follow RESTful routing conventions.
    {
      return View();
    }
    
    [HttpPost("/queen/create")] 
    public ActionResult Create(float userx, float usery, float queenx, float queeny)
    {
      float[] user = {userx, usery};
      float[] queen = {queenx, queeny};
      Queen.Result = Queen.CanAttack(user, queen);
      return RedirectToAction("Show"); //"Show" is the name of the route method.
    }

   [HttpGet("/queen/show")]
   public ActionResult Show()
   {
     return View();
   }
  }
}