namespace Products.Api.Application.Repositories
{
    using Products.Api.Application.Contracts.Services;
    using Products.Api.Business.Models;
    using Products.Api.DataAccess.Contracts.Repositories;
    using Products.Api.DataAccess.Mappers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository  transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        public async Task<Transactions> GetTransaction(Guid idEntity)
        {
            var rate = await _transactionRepository.Get(idEntity);
            return TransactionMapper.Map(rate);
        }
        public async Task<List<Transactions>> GetAllTransactions()
        {
            var transactions = await _transactionRepository.GetAll();
            return transactions.Select(TransactionMapper.Map).ToList();
        }
    }
}
