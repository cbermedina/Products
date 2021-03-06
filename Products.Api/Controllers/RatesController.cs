﻿namespace Products.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Products.Api.Application.Contracts.Services;
    using Products.Api.Mappers;
    using Products.Api.ViewModels;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Controller to work with rates
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RatesController : ControllerBase
    {
        #region Properties
        private readonly IRateService _rateService;
        #endregion

        #region Constructor
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="rateService"></param>
        public RatesController(IRateService rateService)
        {
            _rateService = rateService;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get all rates
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<RatesModel>))]
        public async Task<IActionResult> GetAllRates()
        {
            var lstRates = await _rateService.GetAllRates();
            return Ok(lstRates.Select(RateMapper.Map).ToList());
        } 
        #endregion
    }
}
