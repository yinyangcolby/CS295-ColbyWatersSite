using ColbyWatersSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PeopleList;

namespace ColbyWatersSite.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Forums()
    {
      List<ProfileModel> people = PeopleDB.GetPeople();
      ViewBag.people = people;
      return View();
    }
    [HttpPost]
    public IActionResult Forums(ProfileModel model)
    {

      if (ModelState.IsValid)
      {
        PeopleDB.AddPerson(model);
        PeopleDB.SavePeople();
      }
      List<ProfileModel> people = PeopleDB.GetPeople();
      ViewBag.people = people;
      return View();
    }

    public IActionResult Overview()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
