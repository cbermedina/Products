using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Products.Api.DataAccess.Contracts.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Api.DataAccess.Contracts
{
    public interface IProductsDBContext
    {
         DbSet<ProductEntity> Products { get; set; }
         DbSet<RateEntity> Rates { get; set; }
         DbSet<TransactionEntity> Transactions { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);
    }
}
