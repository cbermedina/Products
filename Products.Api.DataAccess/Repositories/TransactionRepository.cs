namespace Products.Api.DataAccess.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using Products.Api.DataAccess.Contracts;
    using Products.Api.DataAccess.Contracts.Entities;
    using Products.Api.DataAccess.Contracts.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class TransactionRepository : ITransactionRepository
    {
        private readonly IProductsDBContext _productDBContext;

        public TransactionRepository(IProductsDBContext productDBContext)
        {
            _productDBContext = productDBContext;
        }
        public async Task<TransactionEntity> Get(Guid idEntity)
        {
            return await _productDBContext.Transactions.FirstOrDefaultAsync(x => x.Id == idEntity);
        }
        public async Task<List<TransactionEntity>> GetAll()
        {
            return _productDBContext.Transactions.Select(s => new TransactionEntity()
            {
                Amount = s.Amount,
                Id = s.Id,
                Id_product = s.Id_product,
                Id_rate = s.Id_rate,
                Product = s.Product,
                Rate = s.Rate
            }).ToList();
        }

        public async Task<List<TransactionEntity>> GetTransactionsBySku(string sku)
        {
            return _productDBContext.Transactions.Where(w => w.Product.Sku == sku).Select(s => new TransactionEntity()
            {
                Amount = s.Amount,
                Id = s.Id,
                Id_product = s.Id_product,
                Id_rate = s.Id_rate,
                Product = s.Product,
                Rate = s.Rate
            }).ToList();
        }
    }
}
