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
                Sku = dto.Sku,
                Currency = dto.Currency
            };
        }
    }
}
