namespace Products.Api.Application.Contracts.Services
{
    using Products.Api.Business.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface ITransactionService
    {
        Task<List<Transactions>> GetAllTransactions();
        Task<TransactionsTotal> GetTransactionsBySku(string sku);
    }
}
