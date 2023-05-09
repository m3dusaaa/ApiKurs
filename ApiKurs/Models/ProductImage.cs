﻿using System;
using System.Collections.Generic;

namespace ApiKurs.Models
{
    public partial class ProductImage
    {
        public ProductImage()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public byte[]? Image { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
