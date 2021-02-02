using Boutique_Natural.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.ViewModel
{
    public class Article_ViewModel
    {
        public int id { get; set; }

        [StringLength(20, MinimumLength = 4)]
        [Required]
        public string libelle { get; set; }

        [StringLength(300, MinimumLength = 4)]
        [Required]
        public string Description { get; set; }
        [Required]

        public int qte_Stck { get; set; }
        [Required]

        public float prix_unitaire { get; set; }
        public string img1 { get; set; }
       
        public IFormFile file1 { get; set; }
        
        public IList<Ligne_Commande> commandes { get; set; }
    
        public int Cat_Id { get; set; }
        public IList<Categories> categories { get; set; }
    }
}
