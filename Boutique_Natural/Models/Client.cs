using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models
{
    public class Client
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string Adresse { get; set; }
        public Ville GetVille { get; set; }
        [MaxLength(11)]
         public string Tele { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        public IList<Commande> commandes { get; set; }

    }
}
