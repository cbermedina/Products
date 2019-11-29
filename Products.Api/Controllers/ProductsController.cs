namespace Products.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Products.Api.Application.Contracts.Services;
    using Products.Api.Mappers;
    using Products.Api.ViewModels;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Controller to work with products
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region Properties
        private readonly IProductService _productService;
        #endregion

        #region Constructor
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="productService"></param>
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<RatesModel>))]
        public async Task<IActionResult> GetAllProducts()
        {
            var lstProducts = await _productService.GetAllProducts();
            return Ok(lstProducts.Select(ProductMapper.Map).ToList());
        } 
        #endregion
    }
}
