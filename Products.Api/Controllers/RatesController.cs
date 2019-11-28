namespace Products.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Products.Api.ViewModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Controller to work with transactions
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RatesController : ControllerBase
    {
        /// <summary>
        /// Get all transactions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<RatesModel>))]
        public async Task<IActionResult> GetAllRates()
        {
            List<RatesModel> lstRates = new List<RatesModel>();
            //var admin = await _adminService.GetAllAdmins();

            return Ok(lstRates);
        }
    }
}
