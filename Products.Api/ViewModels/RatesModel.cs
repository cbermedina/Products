
namespace Products.Api.ViewModels
{
    using Newtonsoft.Json;
    /// <summary>
    /// Rates Model
    /// </summary>
    public class RatesModel
    {
        /// <summary>
        /// From
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }
        /// <summary>
        /// To
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [JsonProperty("rate")]
        public double Rate { get; set; }
    }
}
