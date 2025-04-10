using Newtonsoft.Json;

namespace Evolix.API.Models
{
    public class CreateTransactionRequest
    {
        [JsonProperty("fromCurrency")]
        public string FromCurrency { get; set; }

        [JsonProperty("toCurrency")]
        public string ToCurrency { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("rate")]
        public decimal Rate { get; set; }

        [JsonProperty("refundAddress")]
        public string RefundAddress { get; set; }

        [JsonProperty("toAddress")]
        public string ToAddress { get; set; }
    }
}
