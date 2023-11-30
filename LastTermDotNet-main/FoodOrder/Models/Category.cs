﻿using System;
using System.Collections.Generic;

namespace FoodOrder.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
