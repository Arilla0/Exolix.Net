using Newtonsoft.Json;

namespace Evolix.API.Models
{
    public class ExchangeRate
    {
        [JsonProperty("fromCurrency")]
        public string FromCurrency { get; set; }

        [JsonProperty("toCurrency")]
        public string ToCurrency { get; set; }

        [JsonProperty("rate")]
        public decimal Rate { get; set; }

        [JsonProperty("minAmount")]
        public decimal MinAmount { get; set; }

        [JsonProperty("maxAmount")]
        public decimal MaxAmount { get; set; }
    }
}
