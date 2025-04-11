using Evolix.API.Models;

namespace Exolix.Api
{
    public interface IExolixClient
    {
        Task<CreateTransactionResponse> CreateExchangeTransactionAsync(string fromCurrency, string toCurrency, decimal amount, decimal rate, string refundAddress, string toAddress);
        Task<List<Currency>> GetAvailableCurrenciesAsync(PaginationFilterRequest request = null);
        Task<List<Currency>> GetCurrencyNetworksAsync(string currencyCode);
        Task<ExchangeRate> GetExchangeRateAsync(string fromCurrency, string toCurrency, decimal amount);
        Task<TransactionStatus> GetTransactionStatusAsync(string transactionId);
    }
}