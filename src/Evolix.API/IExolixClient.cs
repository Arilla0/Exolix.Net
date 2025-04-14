using Evolix.API.Models;

namespace Exolix.Api
{
    public interface IExolixClient
    {
        Task<CreateTransactionResponse> CreateExchangeTransactionAsync(CreateTransactionRequest request = null);
        Task<CurrencyApiResponse    > GetAvailableCurrenciesAsync(PaginationFilterRequest request = null);
        Task<List<CurrencyNetworkDto>> GetCurrencyNetworksAsync(string currencyCode);
        Task<ExchangeRate> GetExchangeRateAsync(string fromCurrency, string toCurrency, decimal amount);
        Task<TransactionResponse> GetTransactionStatusAsync(string transactionId);
        Task<TransactionStatus> GetTransactionsAsync(TransactionQueryParameters request = null);
    }
}