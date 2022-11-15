using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingUmbraco.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductVariation> ProductVariations { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}