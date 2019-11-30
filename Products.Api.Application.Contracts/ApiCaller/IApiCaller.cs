
namespace Products.Api.Application.Contracts.ApiCaller
{
using System.Threading.Tasks;

    public interface IApiCaller
    {
        Task<T> GetServiceResponse<T>(string controller);
    }
}
