using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Api.DataAccess.EntityConfig
{
    public class ProductEntityConfig
    {

        public static void SetEntityBuilder(EntityTypeBuilder<ProductEntity> entityBuilder)
        {

            entityBuilder.ToTable("Product");

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
            //entityBuilder.HasOne(x => x.Office).WithOne(x => x.Admin);
        }
    }
}
