using Lekadex.Database;
using System.Collections.Generic;
using System.Linq;

namespace Lekadex.Core
{
    public class DoctorManager
    {
        private readonly IDoctorRepository mDoctorRepository;
        private readonly IMedicineRepository mMedicineRepository;
        private readonly IPrescriptionRepository mPrescriptionRepository;
        private readonly DoctorsMapper mDoctorsMapper;

        public DoctorManager(IDoctorRepository doctorRepository, 
                             IMedicineRepository medicineRepository, 
                             IPrescriptionRepository prescriptionRepository,
                             DoctorsMapper doctorsMapper)
        {
            mDoctorRepository = doctorRepository;
            mMedicineRepository = medicineRepository;
            mPrescriptionRepository = prescriptionRepository;
            mDoctorsMapper = doctorsMapper;
        }

        public IEnumerable<DoctorDto> GetAllDoctors(string filterString)
        {
            var doctorEntities = mDoctorRepository.GetAllDoctors();

            if (!string.IsNullOrEmpty(filterString))
            {
                doctorEntities = doctorEntities
                    .Where(x => x.FirstName.Contains(filterString) || x.LastName.Contains(filterString));
            }
        }
    }
}
