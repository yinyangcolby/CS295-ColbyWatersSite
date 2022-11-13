using ColbyWatersSite.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ColbyWatersSite.Controllers
{
  public class ReferencesController : Controller
  {
    public IActionResult References()
    {
      return View();
    }

    public IActionResult OnlineMedia()
    {
      return View();
    }

    public IActionResult Print()
    {
      return View();
    }

    public IActionResult InternetScams()
    {
      return View();
    }

  }
}
