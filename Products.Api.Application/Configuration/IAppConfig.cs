namespace Products.Api.Application.Configuration
{
    public interface IAppConfig
    {
        int MaxTrys { get; }
        int SecondsToWait { get; }
        string ServiceUrl { get; }
        int CacheExpireInMinutes { get; }
        string DefaultMoney { get; }
    }
}
