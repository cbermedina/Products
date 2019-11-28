namespace Products.Api.Mappers
{
    using Products.Api.ViewModels;
    /// <summary>
    /// Product Mapper
    /// </summary>
    public static class ProductMapper
    {
        public static ProductsModel Map(Business.Models.Products dto)
        {
            return new ProductsModel()
            {
                Sku = dto.Sku,
                Id = dto.Id,
                Name = dto.Name,
            };
        }

        public static Business.Models.Products Map(ProductsModel entity)
        {
            return new Business.Models.Products()
            {
                Sku = entity.Sku,
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}
