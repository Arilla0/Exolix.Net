namespace Evolix.API.Models
{
    public class PaginationFilterRequest
    {
        /// <summary>
        /// Current page
        /// </summary>
        public int? Page { get; set; } = 1;

        /// <summary>
        /// Size per page
        /// </summary>
        public int? Size { get; set; } = 100;

        /// <summary>
        /// Search by currency code or name
        /// </summary>
        public string? Search { get; set; }

        /// <summary>
        /// Show currency with networks:
        /// true - show with networks
        /// false - don't show with networks (default)
        /// </summary>
        public bool? WithNetworks { get; set; } = true;
    }
}
