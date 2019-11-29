namespace Products.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Products.Api.Application.Contracts.Services;
    using Products.Api.DataAccess.Contracts.Repositories;
    using Products.Api.Mappers;
    using Products.Api.ViewModels;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Controller to work with transactions
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        #region Properties
        private readonly ITransactionService _transactionService; 
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="transactionService"></param>
        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get all transactions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<TransactionsModel>))]
        public async Task<IActionResult> GetAllTransactions()
        {
            var lstTransactions = await _transactionService.GetAllTransactions();
            return Ok(lstTransactions.Select(TransactionMapper.Map).ToList());
        }
        /// <summary>
        /// Get transactions by sku
        /// </summary>
        /// <returns></returns>
        [HttpGet("{sku}")]
        [Produces("application/json", Type = typeof(List<TransactionsModel>))]
        public async Task<IActionResult> GetTransactionsBySku(string sku)
        {
            var lstTransactions = await _transactionService.GetTransactionsBySku(sku);
            return Ok(lstTransactions.Select(TransactionMapper.Map).ToList());
        }
        #endregion
    }
}
