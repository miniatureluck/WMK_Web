using System.ComponentModel.DataAnnotations;

namespace WMK_Web.Models
{
    public class Client
    {
        [Display(Name = "Nr identyfikacyjny")]
        public int Id { get; set; }
        public enum Months { Brak, Styczeń, Luty, Marzec, Kwiecień, Maj, Czerwiec, Lipiec, Sierpień, Wrzesień, Październik, Listopad, Grudzień }
        [Required(ErrorMessage = "Nazwa klienta jest niezbędna.")]
        [Display(Name = "Nazwa klienta")]
        public string Name { get; set; }
        public List<Session>? Sessions { get; set; }
        public DateTime LastUsed { get; set; }
    }
}
