using Boutique_Natural.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.ViewModel
{
    public class Ligne_Cmd_ViewModel
    {
        public int id { get; set; }
        public int qte { get; set; }
        public int id_art { get; set; }
        public Produit article { get; set; }
        public Commande cmd { get; set; }
        public int id_clt { get; set; }
        public Client clt { get; set; }
    }
}
