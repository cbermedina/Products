namespace Products.Api.DataAccess.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Products.Api.DataAccess.Contracts.Entities;
    public class RateEntityConfig
    {

        public static void SetEntityBuilder(EntityTypeBuilder<RateEntity> entityBuilder)
        {

            entityBuilder.ToTable("Rate");

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired().HasDefaultValueSql("NEWID()");
            entityBuilder.Property(x => x.From ).IsRequired().HasMaxLength(10);
            entityBuilder.Property(x => x.To).IsRequired().HasMaxLength(10);
            entityBuilder.Property(x => x.Rate).IsRequired();
        }
    }
}
