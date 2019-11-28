using Microsoft.EntityFrameworkCore;
using Products.Api.DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Api.DataAccess
{
    public class ProductsDBContext : DbContext, IProductsDBContext
    {

       // public DbSet<UserEntity> Users { get; set; }
      


        public ProductsDBContext(DbContextOptions options) : base(options) { }

        public ProductsDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //AdminEntityConfig.SetEntityBuilder(modelBuilder.Entity<AdminEntity>());
            base.OnModelCreating(modelBuilder);
        }
    }
}
