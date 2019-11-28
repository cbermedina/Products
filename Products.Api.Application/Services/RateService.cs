namespace Products.Api.Application.Repositories
{
    using Products.Api.Application.Contracts.Services;
    using Products.Api.Business.Models;
    using Products.Api.DataAccess.Contracts.Repositories;
    using Products.Api.DataAccess.Mappers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class RateService : IRateService
    {
        private readonly IRateRepository _rateRepository;

        public RateService(IRateRepository rateRepository)
        {
            _rateRepository = rateRepository;
        }
        public async Task<Rates> GetRate(Guid idEntity)
        {
            var rate = await _rateRepository.Get(idEntity);
            return RateMapper.Map(rate);
        }
        public async Task<IEnumerable<Rates>> GetAllRates()
        {
            var rates = await _rateRepository.GetAll();
            return rates.Select(RateMapper.Map);
        }
    }
}
