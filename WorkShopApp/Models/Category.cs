﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WorkShopApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        public List<Product> Products { get; set; }
    }
}
