using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models
{
    public class Ligne_Commande
    {
        public int id { get; set; }
        public int id_Commande { get; set; }

        public int id_Article { get; set; }

        [Required]
        public int qte { get; set; }
        [ForeignKey(nameof(id_Article))]
        public Produit article { get; set; }
        [ForeignKey(nameof(id_Commande))]
        public Commande commande { get; set; }
        public int pos { get; set; }
    }
}
