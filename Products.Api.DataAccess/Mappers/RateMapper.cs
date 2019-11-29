namespace Products.Api.DataAccess.Mappers
{
    using Products.Api.Business.Models;
    using Products.Api.DataAccess.Contracts.Entities;
    public static class RateMapper
    {
        public static Rates Map(RateEntity entity)
        {
            return new Rates()
            {
                To = entity.To,
                From = entity.From,
                Rate = entity.Rate
            };
        }
    }
}
