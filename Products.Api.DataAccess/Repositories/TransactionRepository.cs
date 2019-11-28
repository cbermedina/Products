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
            return _productDBContext.Transactions.ToList();
        }
    }
}
