using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OnlineStore.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string picture { get; set; }
        public virtual List<Product> Products { get; set; }
    }

    public class ProductContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}