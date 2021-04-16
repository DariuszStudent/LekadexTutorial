using Lekadex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lekadex.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View(TestDatabasePleaseDelete.Doctors);
        }

        public IActionResult View(int indexOfDoctor)
        {
            return RedirectToAction("Index", "Prescription", TestDatabasePleaseDelete.Doctors.ElementAt(indexOfDoctor));
        }

        public IActionResult Delete(int indexOfDoctor)
        {
            return View(TestDatabasePleaseDelete.Doctors);
        }
    }
}
