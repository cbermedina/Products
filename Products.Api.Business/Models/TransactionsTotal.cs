using System;
using System.Collections.Generic;
using System.Linq;

namespace Products.Api.Business.Models
{
    /// <summary>
    /// Transactions Total DTO
    /// </summary>
    public class TransactionsTotal
    {
        /// <summary>
        /// Result sum Amount to transactions
        /// </summary>
        public double Total
        {
            get
            {
                return Math.Round(Transactions.Sum(c => c.Amount), MidpointRounding.ToEven);
            }
        }
        /// <summary>
        /// list transactions
        /// </summary>
        public List<Transactions> Transactions { get; set; }
    }
}
