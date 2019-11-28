using Products.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Api.Application.Contracts.Services
{
    public interface IRateService
    {
        Task<IEnumerable<Rates>> GetAllRates();
        Task<Rates> GetRate(Guid id);
    }
}
