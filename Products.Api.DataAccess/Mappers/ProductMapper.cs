namespace Products.Api.DataAccess.Mappers
{
    using Products.Api.Business.Models;
    using Products.Api.DataAccess.Contracts.Entities;
    public static class ProductMapper
    {
        public static ProductEntity Map(Products dto)
        {
            return new ProductEntity()
            {
                Sku = dto.Sku,
                Id = dto.Id,
                Name = dto.Name,
            };
        }

        public static Products Map(ProductEntity entity)
        {
            return new Products()
            {
                Sku = entity.Sku,
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}
