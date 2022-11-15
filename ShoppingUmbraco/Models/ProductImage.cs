using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingUmbraco.Models
{
    public class ProductImage : BaseModel
    {
        public string Image { get; set; }
        public int ProductId { get; set; }

        public int? ProductVariationId { get; set; }
        public ProductVariation ProductVariation { get; set; }
        public Product Product { get; set; }
    }
}