using System.ComponentModel.DataAnnotations;

namespace lab10.Data
{
    public class Palata
    {
        public int PalataId { get; set; }

        [Display(Name = "Номер палаты")]
        public string PalataNum { get; set; }

        [Display(Name = "Кол-во коек")]
        public int? CountBeds { get; set; }

        public int OtdelenieId { get; set; }

        public virtual Otdelenie? Otdelenie { get; set; }

        public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}
