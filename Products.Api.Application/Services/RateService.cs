namespace Products.Api.Application.Repositories
{
    using Products.Api.Application.Contracts.Services;
    using Products.Api.Business.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class RateService : IRateService
    {
        private readonly IInformationService _informationService;
        public RateService(IInformationService informationService)
        {
            _informationService = informationService;
        }
        public async Task<List<Rates>> GetAllRates()
        {
            List<Rates> lstRates = new List<Rates>();
            await _informationService.GetInformation(lstRates, "RATES", "rates.json");
            return lstRates;
        }
    }
}
