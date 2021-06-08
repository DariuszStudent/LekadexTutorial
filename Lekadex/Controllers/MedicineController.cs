using Lekadex.Core;
using Lekadex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lekadex.Controllers
{
    public class MedicineController : Controller
    {
        private readonly IDoctorManager mDoctorManager;
        private readonly ViewModelMapper mViewModelMapper;

        private int DoctorId { get; set; }
        private int PrescriptionId { get; set; }

        public MedicineController(IDoctorManager doctorManager, ViewModelMapper viewModelMapper)
        {
            mDoctorManager = doctorManager;
            mViewModelMapper = viewModelMapper;
        }

        public IActionResult Index(int doctorId, int prescriptionId, string filterString)
        {
            DoctorId = doctorId;
            PrescriptionId = prescriptionId;

            var medicineDto = mDoctorManager.GetAllMedicineForAPrescription(prescriptionId, filterString);


            var prescriptionDto = mDoctorManager.GetAllPrescriptionsForADoctor(doctorId, null)
                                                 .FirstOrDefault(x => x.Id == prescriptionId);

            var prescriptionViewModel = mViewModelMapper.Map(prescriptionDto);
            prescriptionViewModel.Medicines = mViewModelMapper.Map(medicineDto);

            return View(prescriptionViewModel);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(MedicineViewModel medicineVm)
        {
            TestDatabasePleaseDelete.Doctors.ElementAt(IndexOfDoctor)
                                .Prescriptions.ElementAt(IndexOfPrescription)
                                .Medicines.Add(medicineVm);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int indexOfMedicine)
        {
            return View();
        }
    }
}
