﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Cart
    {   [Key]
        [ForeignKey("Product")]
        public int product_id { get; set; }
        public DateTime added_at { get; set; }
        public virtual Product Product { get; set; }
    }
}