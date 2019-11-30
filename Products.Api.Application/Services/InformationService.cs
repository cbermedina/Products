namespace Products.Api.Application.Repositories
{
    using Products.Api.Application.Contracts.ApiCaller;
    using Products.Api.Application.Contracts.Services;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class InformationService : IInformationService
    {

        private readonly IApiCaller _apiCaller;
        private readonly ICacheService _cacheService;
        public InformationService(IApiCaller apiCaller, ICacheService cacheService)
        {
            _apiCaller = apiCaller;
            _cacheService = cacheService;
        }
        /// <summary>
        /// Get information to cache
        /// </summary>
        /// <param name="lstTransactions"></param>
        /// <returns></returns>
        public async Task GetInformation<T>(List<T> lst, string key, string controller) where T : class
        {
            try
            {
                var lstResult = await _apiCaller.GetServiceResponse<List<T>>($"/{controller}");
                lst.AddRange(lstResult);
                _cacheService.TryAdd(key, lst);
            }
            catch (Exception ex)
            {
                lst.AddRange(_cacheService.TryGet<List<T>>(key));
            }
        }
    }
}
