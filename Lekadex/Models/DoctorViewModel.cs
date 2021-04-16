using System.Collections.Generic;

namespace Lekadex.Models
{
    public class DoctorViewModel
    {
        public string Name { get; set; }

        public List<PrescriptionViewModel> Prescriptions { get; set; }
    }
}
