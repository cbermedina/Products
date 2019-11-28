namespace Products.Api.DataAccess.Mappers
{
    using Products.Api.Business.Models;
    using Products.Api.DataAccess.Contracts.Entities;

    public static class TransactionMapper
    {
        public static TransactionEntity Map(Transactions dto)
        {
            return new TransactionEntity()
            {
                Amount = dto.Amount,
                Id = dto.Id,
                Id_rate = dto.Id_rate,
                Id_product = dto.Id_product
            };
        }

        public static Transactions Map(TransactionEntity entity)
        {
            return new Transactions()
            {
                Amount = entity.Amount,
                Id = entity.Id,
                Id_product = entity.Id_product,
                Id_rate = entity.Id_rate
            };
        }
    }
}
