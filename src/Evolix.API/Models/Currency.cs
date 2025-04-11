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
}
