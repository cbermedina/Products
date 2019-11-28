using Microsoft.EntityFrameworkCore;
using Products.Api.DataAccess.Contracts;
namespace Products.Api.DataAccess.Repositories
{
    using Products.Api.DataAccess.Contracts.Entities;
    using Products.Api.DataAccess.Contracts.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class RateRepository : IRateRepository
    {
        private readonly IProductsDBContext _productDBContext;

        public RateRepository(IProductsDBContext productDBContext)
        {
            _productDBContext = productDBContext;
        }
        public async Task<RateEntity> Get(Guid idEntity)
        {
            return await _productDBContext.Rates.FirstOrDefaultAsync(x => x.Id == idEntity);
        }
        public async Task<List<RateEntity>> GetAll()
        {
            return _productDBContext.Rates.ToList();
        }
    }
}
