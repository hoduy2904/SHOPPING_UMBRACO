using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingUmbraco.Models
{
    public class ProductVariation : BaseModel
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int Number { get; set; }
        public double PriceOld { get; set; }
        public double PriceCurrent { get; set; }
        public int? VariationId { get; set; }
        public ProductVariation ProductVariate { get; set; }
        public ICollection<ProductVariation> ProductVariations { get; set; }
        public Product Product { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}