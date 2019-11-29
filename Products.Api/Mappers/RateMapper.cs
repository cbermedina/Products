namespace Products.Api.Mappers
{
    using Products.Api.Business.Models;
    using Products.Api.ViewModels;
    /// <summary>
    /// Rate Mapper
    /// </summary>
    public static class RateMapper
    {
        public static RatesModel Map(Rates dto)
        {
            return new RatesModel()
            {
                from = dto.From,
                rate = dto.Rate,
                to = dto.To,
                id=dto.Id
            };
        }

        public static Rates Map(RatesModel entity)
        {
            return new Rates()
            {
                To = entity.to,
                Rate = entity.rate,
                From = entity.from,
                Id = entity.id,
            };
        }
    }
}
