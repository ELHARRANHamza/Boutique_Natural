using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models
{
    public class Produit
    {
        public int id { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Titre_Art { get; set; }

        [StringLength(300, MinimumLength = 4)]
        [Required]
        public string Description { get; set; }
        [Required]

        public int qte_Stck { get; set; }
        [Required]

        public float prix_unitaire { get; set; }
        public string img1 { get; set; }
        public Categories GetCategories { get; set; }
        public IList<Ligne_Commande> commandes { get; set; }
    }
}
