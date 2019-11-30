
namespace Products.Api.ViewModels
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Transactions Total Model
    /// </summary>
    public class TransactionsTotalModel
    {
        /// <summary>
        /// Result sum Amount to transactions
        /// </summary>
        [JsonProperty("total")]
        public double Total { get; set; }
        /// <summary>
        /// list transactions
        /// </summary>
        [JsonProperty("transactions")]
        public List<TransactionsModel> transactionsModels { get; set; }
    }
}
