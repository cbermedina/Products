using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Api.DataAccess.Contracts.Entities;

namespace Products.Api.DataAccess.EntityConfig
{
    public class ProductEntityConfig
    {

        public static void SetEntityBuilder(EntityTypeBuilder<ProductEntity> entityBuilder)
        {

            entityBuilder.ToTable("Product");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Sku).IsRequired().HasMaxLength(10);
        }
    }
}
