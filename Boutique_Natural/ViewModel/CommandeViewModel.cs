using Boutique_Natural.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.ViewModel
{
    public class CommandeViewModel
    {
        public int id { get; set; }
        [Required]
        [StringLength(25,MinimumLength =3)]
        public string nom { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string prenom { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 6)]
        public string Adresse { get; set; }
        public int id_Ville { get; set; }
        public IList<Ville> GetVilles { get; set; }
        [MaxLength(11)]
        public string Tele { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        public string img { get; set; }
        public IList<Commande> commandes { get; set; }
    }
}
