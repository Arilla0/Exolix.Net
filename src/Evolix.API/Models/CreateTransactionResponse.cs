using Newtonsoft.Json;

namespace Evolix.API.Models
{
    public class CreateTransactionResponse
    {
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("amountTo")]
        public decimal AmountTo { get; set; }

        [JsonProperty("rate")]
        public decimal Rate { get; set; }

        [JsonProperty("depositAddress")]
        public string DepositAddress { get; set; }
    }
}
