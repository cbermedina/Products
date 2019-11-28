namespace Products.Api.Mappers
{
    using Products.Api.Business.Models;
    using Products.Api.ViewModels;
    /// <summary>
    /// Transaction Mapper
    /// </summary>
    public static class TransactionMapper
    {
        public static TransactionsModel Map(Transactions dto)
        {
            return new TransactionsModel()
            {
                Amount = dto.Amount,
                Id = dto.Id,
                Id_product = dto.Id_product,
                Id_rate= dto.Id_rate
            };
        }

        public static Transactions Map(TransactionsModel entity)
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
