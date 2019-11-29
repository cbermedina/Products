namespace Products.Api.DataAccess.Contracts.Repositories
{
    using Products.Api.DataAccess.Contracts.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITransactionRepository : IRepository<TransactionEntity>
    {
        Task<List<TransactionEntity>> GetTransactionsBySku(string sku);
    }
}
