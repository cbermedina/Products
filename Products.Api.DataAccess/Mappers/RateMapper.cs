namespace Products.Api.DataAccess.Mappers
{
    using Products.Api.Business.Models;
    using Products.Api.DataAccess.Contracts.Entities;
    public static class RateMapper
    {
        public static RateEntity Map(Rates dto)
        {
            return new RateEntity()
            {
                From = dto.From,
                Id = dto.Id,
                Rate = dto.Rate,
                To = dto.To
            };
        }

        public static Rates Map(RateEntity entity)
        {
            return new Rates()
            {
                To = entity.To,
                Id = entity.Id,
                From = entity.From,
                Rate = entity.Rate
            };
        }
    }
}
