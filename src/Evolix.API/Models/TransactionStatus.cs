using Newtonsoft.Json;

namespace Evolix.API.Models
{
    public class TransactionStatus
    {
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("fromCurrency")]
        public string FromCurrency { get; set; }

        [JsonProperty("toCurrency")]
        public string ToCurrency { get; set; }

        [JsonProperty("amountFrom")]
        public decimal AmountFrom { get; set; }

        [JsonProperty("amountTo")]
        public decimal AmountTo { get; set; }

        [JsonProperty("rate")]
        public decimal Rate { get; set; }
    }
}
