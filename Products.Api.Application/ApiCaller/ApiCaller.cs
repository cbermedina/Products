namespace Products.Api.Application.ApiCaller
{
    using Newtonsoft.Json;
    using Products.Api.Application.Configuration;
    using Products.Api.Application.Contracts.ApiCaller;
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    public class ApiCaller : IApiCaller
    {

        private readonly HttpClient _httpClient;

        public ApiCaller(IAppConfig appConfig)
        {

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(appConfig.ServiceUrl)
            };

            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }


        public async Task<T> GetServiceResponse<T>(string controller)
        {

            var response = await _httpClient.GetAsync(controller);

            if (!response.IsSuccessStatusCode)
                return default(T);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
