namespace Products.Api.Application.Contracts.Services
{
    public interface ICacheService
    {
        T TryGet<T>(string key) where T:class;
        void RemoveItem<T>(string key) where T:class;
        void TryAdd<T>(string key, T value) where T:class;
    }
}
