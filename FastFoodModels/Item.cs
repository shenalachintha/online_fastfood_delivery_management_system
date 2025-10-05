﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodModels
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";

        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public required SubCategory SubCategory { get; set; }
        public required Category Category { get; set; }
    }
}
