using Newtonsoft.Json;

namespace Products.Api.Business.Models
{
    public class Transactions
    {
        [JsonProperty("sku")]
        public string Sku { get; set; }
        [JsonProperty("amount")]
        public double Amount { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
