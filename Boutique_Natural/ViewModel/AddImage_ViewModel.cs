﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.ViewModel
{
    public class AddImage_ViewModel
    {
        public string image { get; set; }
        public IFormFile file { get; set; }
    }
}
