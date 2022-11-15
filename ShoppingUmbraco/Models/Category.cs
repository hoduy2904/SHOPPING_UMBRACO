using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingUmbraco.Models
{
    public class Category : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public string Image { get; set; }
        public Category CategoryParrent { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}