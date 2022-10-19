using Microsoft.AspNetCore.Mvc;

namespace ColbyWatersSite.Controllers
{
  public class ScamsController : Controller
  {
    public IActionResult ScamsToAvoid()
    {
      return View();
    }
  }
}
