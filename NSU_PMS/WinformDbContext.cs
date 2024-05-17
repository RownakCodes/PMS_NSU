using Microsoft.EntityFrameworkCore;
using NSU_PMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSU_PMS
{
    internal class WinformDbContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=NSU_PMS;User Id=ggwp;password=123;TrustServerCertificate=True;");
        }
    }
}
