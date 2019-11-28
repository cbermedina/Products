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
            entityBuilder.Property(x => x.Id).IsRequired();
        }
    }
}
