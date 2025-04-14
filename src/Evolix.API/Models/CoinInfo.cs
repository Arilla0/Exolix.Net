namespace Evolix.API.Models
{
    public class CoinInfo
    {
        /// <summary>
        /// Currency code (e.g., "XMR", "ETH")
        /// </summary>
        public string CoinCode { get; set; } = string.Empty;

        /// <summary>
        /// Full currency name
        /// </summary>
        public string CoinName { get; set; } = string.Empty;

        /// <summary>
        /// Network code
        /// </summary>
        public string Network { get; set; } = string.Empty;

        /// <summary>
        /// Full network name
        /// </summary>
        public string NetworkName { get; set; } = string.Empty;

        /// <summary>
        /// Short network name (if available)
        /// </summary>
        public string? NetworkShortName { get; set; }

        /// <summary>
        /// URL to currency icon
        /// </summary>
        public string Icon { get; set; } = string.Empty;

        /// <summary>
        /// Name for memo/extra ID field (if required)
        /// </summary>
        public string? MemoName { get; set; }
    }
}
