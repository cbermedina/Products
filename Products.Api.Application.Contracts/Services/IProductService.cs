using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Api.Application.Contracts.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Business.Models.Products>> GetAllProducts();
        Task<Business.Models.Products> GetProduct(Guid id);
    }
}
