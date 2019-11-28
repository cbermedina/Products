namespace Products.Api.DataAccess.Contracts.Repositories
{
    using Products.Api.DataAccess.Contracts.Entities;
    using System.Threading.Tasks;
    public interface IProductRepository : IRepository<ProductEntity>
    {
    }
}
