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
      var AllEngineers = _db.Engineers.ToList();
      var AllMachines = _db.Machines.ToList();
      var viewModel = new MyViewModel();
      viewModel.AllEngineers = AllEngineers;
      viewModel.AllMachines = AllMachines;
      return View(viewModel);
    }
  }
}