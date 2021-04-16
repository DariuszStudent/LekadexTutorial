using Lekadex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lekadex.Controllers
{
    public class PrescriptionController : Controller
    {
        public PrescriptionController() { }

        public IActionResult Index(int indexOfDoctor)
        {
            return View(TestDatabasePleaseDelete
                .Doctors.ElementAt(indexOfDoctor));
        }

        public IActionResult View(int indexOfPrescription)
        {
            return RedirectToAction("Index", "Medicine", null);
        }

        public IActionResult Delete(int indexOfPrescription)
        {
            return View();
        }
    }
}
