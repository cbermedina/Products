
namespace Products.Api.ViewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// TransactionsModel
    /// </summary>
    public class TransactionsModel
    {
        /// <summary>
        /// Product code
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
