namespace Evolix.API.Models
{
    public class CurrencyNetwork
    {
        /// <summary>
        /// Network code
        /// </summary>
        public string Network { get; set; }

        /// <summary>
        /// Network name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Network short name
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Address regex
        /// </summary>
        public string AddressRegex { get; set; }

        /// <summary>
        /// Network notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Is network default
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Decimal places
        /// </summary>
        public int? Decimal { get; set; }

        /// <summary>
        /// Network icon
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Link to block explorer
        /// </summary>
        public string BlockExplorer { get; set; }

        /// <summary>
        /// Network minimum amount to deposit
        /// </summary>
        public decimal? DepositMinAmount { get; set; }

        /// <summary>
        /// Network has extra ID requirement
        /// </summary>
        public bool MemoNeeded { get; set; }

        /// <summary>
        /// Network extra ID name
        /// </summary>
        public string MemoName { get; set; }

        /// <summary>
        /// Memo regex
        /// </summary>
        public string MemoRegex { get; set; }

        /// <summary>
        /// Network precision
        /// </summary>
        public bool Precision { get; set; }

        /// <summary>
        /// Contract address
        /// </summary>
        public string Contract { get; set; }
    }
}
