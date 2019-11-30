namespace Products.Api.Mappers
{
    using Products.Api.Business.Models;
    using Products.Api.ViewModels;
    using System.Linq;

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
        public static TransactionsTotalModel Map(TransactionsTotal dto)
        {
            return new TransactionsTotalModel()
            {
                Total = dto.Total,
                transactionsModels = dto.Transactions.Select(TransactionMapper.Map).ToList()
            };
        }
    }
}
