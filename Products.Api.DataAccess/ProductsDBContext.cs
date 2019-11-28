using Microsoft.EntityFrameworkCore;
using Products.Api.DataAccess.Contracts;
using Products.Api.DataAccess.Contracts.Entities;
using Products.Api.DataAccess.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Api.DataAccess
{
    public class ProductsDBContext : DbContext, IProductsDBContext
    {

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<RateEntity> Rates { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }



        public ProductsDBContext(DbContextOptions options) : base(options) { }

        public ProductsDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RateEntityConfig.SetEntityBuilder(modelBuilder.Entity<RateEntity>());
            ProductEntityConfig.SetEntityBuilder(modelBuilder.Entity<ProductEntity>());
            TransactionEntityConfig.SetEntityBuilder(modelBuilder.Entity<TransactionEntity>());
            base.OnModelCreating(modelBuilder);
        }
    }
}
