using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Api.Application.Contracts.Services
{
    public interface IInformationService
    {
        Task GetInformation<T>(List<T> lst, string key, string controller) where T : class;
    }
}
