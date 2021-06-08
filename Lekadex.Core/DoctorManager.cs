using Lekadex.Database;
using System.Collections.Generic;
using System.Linq;

namespace Lekadex.Core
{
    public class DoctorManager : IDoctorManager
    {
        private readonly IDoctorRepository mDoctorRepository;
        private readonly IMedicineRepository mMedicineRepository;
        private readonly IPrescriptionRepository mPrescriptionRepository;
        private readonly DTOMapper mDTOMapper;

        public DoctorManager(IDoctorRepository doctorRepository,
                             IMedicineRepository medicineRepository,
                             IPrescriptionRepository prescriptionRepository,
                             DTOMapper doctorsMapper)
        {
            mDoctorRepository = doctorRepository;
            mMedicineRepository = medicineRepository;
            mPrescriptionRepository = prescriptionRepository;
            mDTOMapper = doctorsMapper;
        }

        public IEnumerable<DoctorDto> GetAllDoctors(string filterString)
        {
            var doctorEntities = mDoctorRepository.GetAllDoctors();

            if (!string.IsNullOrEmpty(filterString))
            {
                doctorEntities = doctorEntities
                    .Where(x => x.FirstName.Contains(filterString) || x.LastName.Contains(filterString));
            }

            return mDTOMapper.Map(doctorEntities);
        }

        public IEnumerable<PrescriptionDto> GetAllPrescriptionsForADoctor(int doctorId, string filterString)
        {
            var prescriptionEntities = mPrescriptionRepository.GetAllPrescriptions()
                                                              .Where(x => x.DoctorId == doctorId);

            if (!string.IsNullOrEmpty(filterString))
            {
                prescriptionEntities = prescriptionEntities
                    .Where(x => x.Name.Contains(filterString));
            }

            return mDTOMapper.Map(prescriptionEntities);
        }

        public IEnumerable<MedicineDto> GetAllMedicineForAPrescription(int prescriptionId, string filterString)
        {
            var medicineEntities = mMedicineRepository.GetAllMedicines()
                                   .Where(x => x.PrescriptionId == prescriptionId);

            if (!string.IsNullOrEmpty(filterString))
            {
                medicineEntities = medicineEntities
                    .Where(x => x.Name.Contains(filterString) ||
                                x.CompanyName.Contains(filterString) ||
                                x.ActiveSubstance.Contains(filterString));
            }

            return mDTOMapper.Map(medicineEntities);
        }

        public void AddNewMedicine(MedicineDto medicine, int prescriptionId)
        {
            var entity = mDTOMapper.Map(medicine);

            entity.PrescriptionId = prescriptionId;

            mMedicineRepository.AddNew(entity);
        }

        public void AddNewPrescription(PrescriptionDto prescription, int doctorId)
        {
            var entity = mDTOMapper.Map(prescription);

            entity.DoctorId = doctorId;

            mPrescriptionRepository.AddNew(entity);
        }

        public void AddNewDoctor(DoctorDto doctor)
        {
            var entity = mDTOMapper.Map(doctor);

            mDoctorRepository.AddNew(entity);
        }

        public bool DeleteMedicine(MedicineDto medicine)
        {
            var entity = mDTOMapper.Map(medicine);

            return mMedicineRepository.Delete(entity);
        }

        public bool DeletePrescription(PrescriptionDto prescription)
        {
            var entity = mDTOMapper.Map(prescription);

            return mPrescriptionRepository.Delete(entity);
        }

        public bool DeleteDoctor(DoctorDto doctor)
        {
            var entity = mDTOMapper.Map(doctor);

            return mDoctorRepository.Delete(entity);
        }
    }
}
