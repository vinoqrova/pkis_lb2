using System.ComponentModel.DataAnnotations;

namespace lab10.Data
{
    public class Patient
    {
        public int PatientId { get; set; }
        [Display(Name = "Имя")]
        public string? PatientFirstName { get; set; }
        [Display(Name = "Фамилия")]
        public string? PatientLastName { get; set; }
        [Display(Name = "Отчество")]
        public string? PatientMiddleName { get; set; }
        [Display(Name = "Дата рождения")]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "Пол")]
        public string? Genger { get; set; }
        [Display(Name = "Диагноз")]
        public string? Diagnos { get; set; }

        public int PalataId { get; set; }

        public virtual Palata? Palata { get; set; }
    }
}
