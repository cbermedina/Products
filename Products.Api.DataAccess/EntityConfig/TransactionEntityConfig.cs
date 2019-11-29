namespace Products.Api.DataAccess.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Products.Api.DataAccess.Contracts.Entities;
    public class TransactionEntityConfig
    {

        public static void SetEntityBuilder(EntityTypeBuilder<TransactionEntity> entityBuilder)
        {

            entityBuilder.ToTable("Transaction");

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired().HasDefaultValueSql("NEWID()");
            entityBuilder.HasOne(x => x.Product).WithMany(x => x.Transaction).HasForeignKey(x => x.Id_product);
            entityBuilder.HasOne(x => x.Rate).WithMany(x => x.Transaction).HasForeignKey(x => x.Id_rate);
            entityBuilder.Property(x => x.Id_product ).IsRequired();
            entityBuilder.Property(x => x.Id_rate).IsRequired();
            entityBuilder.Property(x => x.Amount).IsRequired();

        }
    }
}
