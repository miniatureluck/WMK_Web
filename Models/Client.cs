using System.ComponentModel.DataAnnotations;

namespace WMK_Web.Models
{
    public class Client
    {
        [Display(Name = "Nr identyfikacyjny")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Nazwa klienta jest niezbędna.")]
        [Display(Name = "Nazwa klienta")]
        public string Name { get; set; }
        [Display(Name = "Data dodania")]
        public DateTime Created { get; set; }
        [Display(Name = "Data modyfikacji")]
        public DateTime LastUsed { get; set; }
    }
}
