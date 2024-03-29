﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace KTApp3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required] [StringLength(200)] public string Name { get; set; }
        [Required] [StringLength(16)] public string VAT { get; set; }
        public bool Enabled { get; set; }
    }
}
