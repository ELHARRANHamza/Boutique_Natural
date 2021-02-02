using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.ViewModel
{
    public class Create_Register_ViewModel
    {
        public int id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string nom { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string prenom { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirme Password")]
        [Compare("password",
         ErrorMessage = "Password and Confirmation Do Not Match.")]
        public string Compare_Password { get; set; }
    }
}
