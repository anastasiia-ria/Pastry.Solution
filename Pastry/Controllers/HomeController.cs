using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Pastry.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Pastry.Controllers
{
  public class HomeController : Controller
  {
    private readonly PastryContext _db;

    public HomeController(PastryContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Treats = _db.Treats.ToList();
      ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }

  }
}