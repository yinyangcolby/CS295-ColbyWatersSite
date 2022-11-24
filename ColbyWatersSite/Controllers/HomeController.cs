using ColbyWatersSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ColbyWatersSite.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private CommentDBContext context { get; set; }

    public HomeController(ILogger<HomeController> logger, CommentDBContext ctx)
    {
      _logger = logger;
      context = ctx;
    }
    
    public IActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public IActionResult AddComment()
    {
      return View("AddComment", new CommentModel());
    }


    [HttpGet]
    public IActionResult Forums()
    {
      var comments = context.Comments.OrderByDescending(s => s.Date).ToList();
      return View(comments);
    }

    [HttpPost]
    public IActionResult AddComment(CommentModel model)
    {
      if (ModelState.IsValid)
      {
        model.Date = DateTime.Now.ToString("d");
        context.Add(model);
        context.SaveChanges();
        return RedirectToAction("Forums", "Home");
      }
      else
      {
        return View(model);
      }
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
