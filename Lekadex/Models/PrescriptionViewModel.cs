using System.Collections.Generic;

namespace Lekadex.Models
{
    public class PrescriptionViewModel
    {
        public string Name { get; set; }

        public List<MedicineViewModel> Medicines { get; set; }
    }
}
