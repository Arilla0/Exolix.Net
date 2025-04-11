namespace Evolix.API.Models
{
    public class ApiResponse<T>
    {
        /// <summary>
        /// List of items
        /// </summary>
        public List<T> Data { get; set; }

        /// <summary>
        /// Count of items
        /// </summary>
        public int Count { get; set; }
    }
}
