using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.ViewModel
{
    public class Create_Roles
    {
        public string id { get; set; }
        [Required]
        public string nom_role { get; set; }
    }
}
