using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models
{
    public class AppUsers:IdentityUser
    {

        public string nom { get; set; }
        public string prenom { get; set; }
        public string rue { get; set; }
        public string image { get; set; }
        public string UserType { get; set; }
    }
}
