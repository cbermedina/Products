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
    public class TransactionsController : ControllerBase
    {
        /// <summary>
        /// Get all transactions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<TransactionsModel>))]
        public async Task<IActionResult> GetAllTransactions()
        {
            List<TransactionsModel> lstTransactions = new List<TransactionsModel>();
            //var admin = await _adminService.GetAllAdmins();

            return Ok(lstTransactions);
        }
    }
}
