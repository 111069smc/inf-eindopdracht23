using System.ComponentModel.DataAnnotations;

namespace Infproject.Models
{
    public class Person
    {
       
        [Required(ErrorMessage = "Gelieve uw voornaam in te vullen")]
        [Display(Name = "Voornaam")]
        public string voornaam { get; set; }
        

        [Required(ErrorMessage = "Achternaam is een verplicht veld")]
        [Display(Name = "Achternaam")]
        public string achternaam { get; set; }
       

        [Required(ErrorMessage = "Emailadres is verplicht")]
        [EmailAddress(ErrorMessage = "Geen geldig email adres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bericht is verplicht")]
        [Display(Name = "Bericht")]
        public string bericht { get; set; }
    }
}