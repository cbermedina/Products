
using Newtonsoft.Json;

namespace Products.Api.ViewModels
{
    /// <summary>
    /// Transactions Model
    /// </summary>
    public class TransactionsModel
    {
        /// <summary>
        /// Sku
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
