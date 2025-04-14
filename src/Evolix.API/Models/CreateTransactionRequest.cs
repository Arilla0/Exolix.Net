using Newtonsoft.Json;

namespace Evolix.API.Models
{
    public class CreateTransactionRequestOLD
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
    public class CreateTransactionRequest
    {
        /// <summary>
        /// Currency to exchange from
        /// </summary>
        public string CoinFrom { get; set; }

        /// <summary>
        /// Network to exchange from
        /// </summary>
        public string NetworkFrom { get; set; }

        /// <summary>
        /// Currency to exchange to
        /// </summary>
        public string CoinTo { get; set; }

        /// <summary>
        /// Network to exchange to
        /// </summary>
        public string NetworkTo { get; set; }

        /// <summary>
        /// Amount of currency to send
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Amount of currency to get
        /// </summary>
        public decimal? WithdrawalAmount { get; set; }

        /// <summary>
        /// Address where the exchange result will be sent to
        /// </summary>
        public string WithdrawalAddress { get; set; }

        /// <summary>
        /// Extra ID for withdrawalAddress in case it is required
        /// </summary>
        public string WithdrawalExtraId { get; set; }

        /// <summary>
        /// The type of the coin rate: float - Floating, fixed - Fixed Default
        /// </summary>
        public string RateType { get; set; }

        /// <summary>
        /// Address for refund
        /// </summary>
        public string RefundAddress { get; set; }

        /// <summary>
        /// Extra ID for refund address
        /// </summary>
        public string RefundExtraId { get; set; }
    }
}
