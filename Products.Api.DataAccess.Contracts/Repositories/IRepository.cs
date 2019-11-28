namespace Products.Api.DataAccess.Contracts.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Guid id);
    }
}
