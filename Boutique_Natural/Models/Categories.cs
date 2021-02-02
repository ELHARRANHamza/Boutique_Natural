using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models
{
    public class Categories
    {
        public int id { get; set; }
        [Required]
        [StringLength(25,MinimumLength = 3)]
        public string cat_Nom { get; set; }
        public IList<Produit> GetProduits { get; set; }
    }
}
