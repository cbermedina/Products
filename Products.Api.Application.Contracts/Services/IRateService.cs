using Products.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Api.Application.Contracts.Services
{
    public interface IRateService
    {
        Task<List<Rates>> GetAllRates();
    }
}
