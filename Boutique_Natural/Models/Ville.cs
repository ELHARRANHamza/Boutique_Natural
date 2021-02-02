using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models
{
    public class Ville
    {
        public int id { get; set; }
        public string ville_Name { get; set; }
        public IList<Client> GetClients { get; set; }
    }
}
