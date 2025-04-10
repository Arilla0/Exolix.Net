using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Evolix.API.Exceptions;
using Evolix.API.Models;
using Newtonsoft.Json;

namespace Exolix.Api
{
    public class ExolixClient : IExolixClient
    {
        private readonly HttpClient _httpClient;

        public ExolixClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://exolix.com/api/v2/")
            };
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<List<Currency>> GetAvailableCurrenciesAsync()
        {
            var response = await _httpClient.GetAsync("currencies");
            return await HandleResponse<List<Currency>>(response);
        }

        public async Task<ExchangeRate> GetExchangeRateAsync(string fromCurrency, string toCurrency, decimal amount)
        {
            var endpoint = $"rate?from={fromCurrency}&to={toCurrency}&amount={amount}";
            var response = await _httpClient.GetAsync(endpoint);
            return await HandleResponse<ExchangeRate>(response);
        }

        public async Task<CreateTransactionResponse> CreateExchangeTransactionAsync(
            string fromCurrency,
            string toCurrency,
            decimal amount,
            decimal rate,
            string refundAddress,
            string toAddress)
        {
            var request = new CreateTransactionRequest
            {
                FromCurrency = fromCurrency,
                ToCurrency = toCurrency,
                Amount = amount,
                Rate = rate,
                RefundAddress = refundAddress,
                ToAddress = toAddress
            };

            var content = new StringContent(JsonConvert.SerializeObject(request));
            var response = await _httpClient.PostAsync("transactions", content);
            return await HandleResponse<CreateTransactionResponse>(response);
        }

        public async Task<TransactionStatus> GetTransactionStatusAsync(string transactionId)
        {
            var response = await _httpClient.GetAsync($"transactions/{transactionId}");
            return await HandleResponse<TransactionStatus>(response);
        }

        private async Task<T> HandleResponse<T>(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ExolixApiException(
                    $"API request failed with status code {response.StatusCode}: {content}");
            }

            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
