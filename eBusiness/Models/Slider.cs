﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBusiness.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string RedirectUrl { get; set; }
    }
}