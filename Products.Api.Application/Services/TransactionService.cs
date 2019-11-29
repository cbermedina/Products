namespace Products.Api.Application.Repositories
{
    using Products.Api.Application.Contracts.Services;
    using Products.Api.Business;
    using Products.Api.Business.Models;
    using Products.Api.DataAccess.Contracts.Entities;
    using Products.Api.DataAccess.Contracts.Repositories;
    using Products.Api.DataAccess.Mappers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IRateRepository _rateRepository;
        private CalculateAmount _calculateAmount;

        public TransactionService(ITransactionRepository  transactionRepository, IRateRepository rateRepository)
        {
            _transactionRepository = transactionRepository;
            _rateRepository = rateRepository;
        }
        public async Task<List<Transactions>> GetTransactionsBySku(string sku)
        {
            var allRates =await _rateRepository.GetAll();
            var lstTransactions = await _transactionRepository.GetTransactionsBySku(sku);
             _calculateAmount = new CalculateAmount(allRates.Select(RateMapper.Map).ToList());
            var result = lstTransactions.Select(transaction => ConvertTransaction(transaction)).ToList();
            return result;
        }

        private  Transactions ConvertTransaction(TransactionEntity transaction)
        {
            var dd = _calculateAmount.HomologateAmount(transaction.Rate.From, transaction.Rate.To, transaction.Rate.Rate);
            return new Transactions {  };
        }

        public async Task<List<Transactions>> GetAllTransactions()
        {
            var transactions = await _transactionRepository.GetAll();
            return transactions.Select(TransactionMapper.Map).ToList();
        }
    }
}
