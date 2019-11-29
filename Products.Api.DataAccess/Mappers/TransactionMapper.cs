namespace Products.Api.DataAccess.Mappers
{
    using Products.Api.Business.Models;
    using Products.Api.DataAccess.Contracts.Entities;

    public static class TransactionMapper
    {
        public static Transactions Map(TransactionEntity entity)
        {
            return new Transactions()
            {
                Amount = entity.Amount,
                Currency = entity.Rate.To,
                Sku = entity.Product.Sku
            };
        }
    }
}
