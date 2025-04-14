using Newtonsoft.Json;

namespace Evolix.API.Models
{
    public class Currency
    {
        /// <summary>
        /// Currency code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Currency name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Currency icon
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Currency notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// List of currency networks (only when withNetworks=true)
        /// </summary>
        public List<CurrencyNetwork> Networks { get; set; }
    }
    public class CurrencyApiResponse
    {
        /// <summary>
        /// List of currency items
        /// </summary>
        public List<CurrencyDto> Data { get; set; } = new List<CurrencyDto>();

        /// <summary>
        /// Total count of items available
        /// </summary>
        public int Count { get; set; }
    }

    public class CurrencyDto
    {
        /// <summary>
        /// Currency code (e.g., "BTC", "ETH")
        /// </summary>
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Full currency name (e.g., "Bitcoin", "Ethereum")
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// URL to currency icon/image
        /// </summary>
        public string Icon { get; set; } = string.Empty;

        /// <summary>
        /// Additional notes about the currency
        /// </summary>
        public string Notes { get; set; } = string.Empty;

        /// <summary>
        /// List of available networks for this currency
        /// (Only populated when withNetworks=true in request)
        /// </summary>
        public List<CurrencyNetworkDto> Networks { get; set; } = new List<CurrencyNetworkDto>();
    }

    public class CurrencyNetworkDto
    {
        /// <summary>
        /// Network identifier code
        /// </summary>
        public string Network { get; set; } = string.Empty;

        /// <summary>
        /// Full network name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Short display name for the network
        /// </summary>
        public string ShortName { get; set; } = string.Empty;

        /// <summary>
        /// Regex pattern for validating addresses (nullable)
        /// </summary>
        public string? AddressRegex { get; set; }

        /// <summary>
        /// Additional notes about the network
        /// </summary>
        public string Notes { get; set; } = string.Empty;

        /// <summary>
        /// Indicates if this is the default network for the currency
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Number of decimal places (nullable)
        /// </summary>
        public int? Decimal { get; set; }

        /// <summary>
        /// URL to network icon/image (nullable)
        /// </summary>
        public string? Icon { get; set; }

        /// <summary>
        /// URL to block explorer (nullable)
        /// </summary>
        public string? BlockExplorer { get; set; }

        /// <summary>
        /// Minimum deposit amount for this network (nullable)
        /// </summary>
        public decimal? DepositMinAmount { get; set; }

        /// <summary>
        /// Indicates if memo/extra ID is required
        /// </summary>
        public bool MemoNeeded { get; set; }

        /// <summary>
        /// Name for the memo/extra ID field (nullable)
        /// </summary>
        public string? MemoName { get; set; }

        /// <summary>
        /// Regex pattern for memo/extra ID validation (nullable)
        /// </summary>
        public string? MemoRegex { get; set; }

        /// <summary>
        /// Network precision setting
        /// </summary>
        public bool Precision { get; set; }

        /// <summary>
        /// Smart contract address (nullable, for tokens)
        /// </summary>
        public string? Contract { get; set; }
    }
}
