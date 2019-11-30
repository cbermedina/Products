namespace Products.Api.Application.Services
{
    using Microsoft.Extensions.Caching.Memory;
    using Products.Api.Application.Configuration;
    using Products.Api.Application.Contracts.Services;
    using System;
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IAppConfig _appConfig;
        public CacheService(IMemoryCache memoryCache, IAppConfig appConfig)
        {
            _memoryCache = memoryCache;
            _appConfig = appConfig;
        }
        public void RemoveItem<T>(string key) where T : class
        {
            if (_memoryCache.Get<T>(key) != null)
            {
                _memoryCache.Remove(key);
            }
        }

        public void TryAdd<T>(string key, T value) where T : class
        {
            _memoryCache.Set<T>(key, value, DateTime.Now.AddMinutes(_appConfig.CacheExpireInMinutes));
        }
        public T TryGet<T>(string key) where T : class
        {
            return _memoryCache.Get<T>(key);
        }
    }
}
