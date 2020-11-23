using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECO.Models
{
    public class ECODBContext : DbContext
    {
        public ECODBContext()
            : base("name=ShopDbContext")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    }
}