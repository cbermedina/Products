using Products.Api.Application.Contracts.Services;
using Products.Api.DataAccess.Contracts.Repositories;
using Products.Api.DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Api.Application.Repositories
{
    public class ProductService : IProductService
    {
        //CRUD -->  READ 

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Business.Models.Products> GetProduct(Guid idEntity)
        {
            var product = await _productRepository.Get(idEntity);
            return ProductMapper.Map(product);
        }
        public async Task<IEnumerable<Business.Models.Products>> GetAllProducts()
        {
            var products = await _productRepository.GetAll();
            return products.Select(ProductMapper.Map);
        }
    }
}
