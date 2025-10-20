using System.ComponentModel.DataAnnotations;

namespace lab10.Data
{
    public class Otdelenie
    {
        public int OtdelenieId { get; set; }

        [Display(Name = "Название отделения")]
        public string? OtdelenieName { get; set; }

        [Display(Name = "Заведующий")]
        public string? HeadDoc { get; set; }

        [Display(Name = "Кол-во палат")]
        public int? CountRoom { get; set; }

        public virtual ICollection<Palata> Palatas { get; set; } = new List<Palata>();
    }
}
