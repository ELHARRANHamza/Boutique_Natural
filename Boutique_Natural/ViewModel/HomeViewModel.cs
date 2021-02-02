using Boutique_Natural.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.ViewModel
{
    public class HomeViewModel
    {
        public IList<Categories> GetCategories { get; set; }
        public IList<Produit> GetProduits { get; set; }

    }
}
