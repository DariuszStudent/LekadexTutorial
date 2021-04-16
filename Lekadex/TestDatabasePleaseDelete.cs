using Lekadex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lekadex
{
    public static class TestDatabasePleaseDelete
    {
        public static List<DoctorViewModel> Doctors { get; set; } =  new List<DoctorViewModel>
        {
            new DoctorViewModel
            {
                Name = "Darek",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Magnez"
                            },
                            new MedicineViewModel
                            {
                                Name = "Aspirina"
                            },
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Ibuprom"
                            },
                            new MedicineViewModel
                            {
                                Name = "Cetanol"
                            },
                        }
                    }
                }
            },
            new DoctorViewModel
            {
                Name = "Elwira",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 3",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Zioło"
                            },
                            new MedicineViewModel
                            {
                                Name = "Wilk"
                            },
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 4",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Groźne"
                            },
                            new MedicineViewModel
                            {
                                Name = "Auchanus"
                            },
                        }
                    }
                }
            },
            new DoctorViewModel
            {
                Name = "Lena",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 5",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Biedronus"
                            },
                            new MedicineViewModel
                            {
                                Name = "Lidlowiec"
                            },
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 6",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Tescoman"
                            },
                            new MedicineViewModel
                            {
                                Name = "Kentaprofina"
                            },
                        }
                    }
                }
            },
        };
    }
}
