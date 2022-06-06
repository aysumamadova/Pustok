﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task123.Models
{
    public class Products
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
        public double DiscountedPrice { get; set; }
        public string InfoText { get; set; }
        public string Desc { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNew { get; set; }
        public Genre Genre { get; set; }
        public Author Author { get; set; }
    }
}
