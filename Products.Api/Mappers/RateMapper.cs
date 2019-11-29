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
                From = dto.From,
                Rate = dto.Rate,
                To = dto.To,
            };
        }

        public static Rates Map(RatesModel entity)
        {
            return new Rates()
            {
                To = entity.To,
                Rate = entity.Rate,
                From = entity.From,
            };
        }
    }
}
