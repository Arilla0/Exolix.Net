namespace Evolix.API.Models
{
    public class TransactionResponse
    {
        /// <summary>
        /// Unique transaction ID
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Amount to exchange (in source currency)
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Amount to receive (in destination currency)
        /// </summary>
        public decimal AmountTo { get; set; }

        /// <summary>
        /// Source currency details
        /// </summary>
        public CoinInfo CoinFrom { get; set; } = new CoinInfo();

        /// <summary>
        /// Destination currency details
        /// </summary>
        public CoinInfo CoinTo { get; set; } = new CoinInfo();

        /// <summary>
        /// Optional transaction comment
        /// </summary>
        public string? Comment { get; set; }

        /// <summary>
        /// Transaction creation timestamp
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Deposit address for the source currency
        /// </summary>
        public string DepositAddress { get; set; } = string.Empty;

        /// <summary>
        /// Extra ID/memo for deposit (if required)
        /// </summary>
        public string? DepositExtraId { get; set; }

        /// <summary>
        /// Withdrawal address for the destination currency
        /// </summary>
        public string WithdrawalAddress { get; set; } = string.Empty;

        /// <summary>
        /// Extra ID/memo for withdrawal (if required)
        /// </summary>
        public string WithdrawalExtraId { get; set; } = string.Empty;

        /// <summary>
        /// Information about the incoming transaction hash
        /// </summary>
        public TransactionHash HashIn { get; set; } = new TransactionHash();

        /// <summary>
        /// Information about the outgoing transaction hash
        /// </summary>
        public TransactionHash HashOut { get; set; } = new TransactionHash();

        /// <summary>
        /// Exchange rate applied
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// Type of rate (fixed/float)
        /// </summary>
        public string RateType { get; set; } = string.Empty;

        /// <summary>
        /// Refund address (if applicable)
        /// </summary>
        public string? RefundAddress { get; set; }

        /// <summary>
        /// Refund extra ID/memo (if applicable)
        /// </summary>
        public string? RefundExtraId { get; set; }

        /// <summary>
        /// Current transaction status
        /// </summary>
        public string Status { get; set; } = string.Empty;
    }
}
