using Microsoft.EntityFrameworkCore;
using Products.Api.DataAccess.Contracts;
using Products.Api.DataAccess.Contracts.Entities;
using Products.Api.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Api.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        //CRUD -->  READ 

        private readonly IProductsDBContext _productDBContext;

        public ProductRepository(IProductsDBContext productDBContext)
        {
            _productDBContext = productDBContext;
        }
        public async Task<ProductEntity> Get(Guid idEntity)
        {
            var result = await _productDBContext.Products.FirstOrDefaultAsync(x => x.Id == idEntity);

            return result;

        }
        public async Task<IEnumerable<ProductEntity>> GetAll()
        {
            return _productDBContext.Products.Select(x => x);
        }
    }
}
