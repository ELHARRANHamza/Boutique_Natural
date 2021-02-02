using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models
{
    public class Commande
    {
        public int id { get; set; }
        public DateTime date_Cmd { get; set; }
        public Client client { get; set; }
        public IList<Ligne_Commande> article { get; set; }
    }
}
