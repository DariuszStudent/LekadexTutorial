using Lekadex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace Lekadex.Controllers
{
    public class MedicineController : Controller
    {
        public MedicineController()
        {
           
        }

        public IActionResult Index(int indexOfDoctor, int indexOfPrescription)
        {
            return View(TestDatabasePleaseDelete
                .Doctors.ElementAt(indexOfDoctor)
                .Prescriptions.ElementAt(indexOfPrescription));
        }

        public IActionResult Delete(int indexOfMedicine)
        {
            return View();
        }
    }
}
