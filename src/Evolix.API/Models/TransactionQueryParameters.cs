namespace Evolix.API.Models
{
    public class TransactionQueryParameters
    {
        /// <summary>
        /// Current page number (1-based)
        /// </summary>
        //[FromQuery(Name = "page")]
        public int? Page { get; set; } = 1;

        /// <summary>
        /// Number of items per page
        /// </summary>
        //[FromQuery(Name = "size")]
        public int? Size { get; set; } = 50;

        /// <summary>
        /// Search term for transaction ID
        /// </summary>
        //[FromQuery(Name = "search")]
        public string? Search { get; set; }

        /// <summary>
        /// Field to sort by
        /// </summary>
        //[FromQuery(Name = "sort")]
        public string? Sort { get; set; }

        /// <summary>
        /// Sort order (asc or desc)
        /// </summary>
        //[FromQuery(Name = "order")]
        public string? Order { get; set; }

        /// <summary>
        /// Start date for filtering transactions (inclusive)
        /// </summary>
        //[FromQuery(Name = "dateFrom")]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// End date for filtering transactions (inclusive)
        /// </summary>
        //[FromQuery(Name = "dateTo")]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Comma-separated list of statuses to filter by
        /// </summary>
        //[FromQuery(Name = "statuses")]
        public string? Statuses { get; set; }

        /// <summary>
        /// Validates that order parameter is either 'asc' or 'desc'
        /// </summary>
        public bool IsValidOrder() =>
            string.IsNullOrEmpty(Order) ||
            Order.Equals("asc", StringComparison.OrdinalIgnoreCase) ||
            Order.Equals("desc", StringComparison.OrdinalIgnoreCase);
    }
}
