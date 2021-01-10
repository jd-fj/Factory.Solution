using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      var viewModel = new MyViewModel();
      viewModel.AllEngineers = _db.Engineers.ToList();
      viewModel.AllMachines = _db.Machines.ToList();
      return View(viewModel);
    }
  }
}