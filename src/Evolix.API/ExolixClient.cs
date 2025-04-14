using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Evolix.API.Exceptions;
using Evolix.API.Models;
using Newtonsoft.Json;

namespace Exolix.Api
{
    public class ExolixConfig
    {
        public string AuthorizationToken { get; set; }
        public string BaseAddress { get; set; } = "https://exolix.com/api/v2/";
    }
    public class ExolixClient : IExolixClient
    {
        private readonly HttpClient _httpClient;
        private readonly ExolixConfig _config;

        public ExolixClient(ExolixConfig config)
        {
            if (config == null)
            {
                return;
            }
            _config = config;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_config.BaseAddress)
            };
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("Authorization", _config.AuthorizationToken);
        }

        public async Task<CurrencyApiResponse> GetAvailableCurrenciesAsync(PaginationFilterRequest request = null)
        {
            request = request ?? new PaginationFilterRequest();
            var url = _config.BaseAddress+$"currencies?page={request.Page}&size={request.Size}&withNetworks={request.WithNetworks}";//TODO add params form request
            var response = await _httpClient.GetAsync(url);
            return await HandleResponse<CurrencyApiResponse>(response);
        }
        public async Task<List<CurrencyNetworkDto>> GetCurrencyNetworksAsync(string currencyCode)
        {
            //https://exolix.com/api/v2/currencies/{code}/networks
            var url = _config.BaseAddress+$"currencies/{currencyCode}/networks";
            var response = await _httpClient.GetAsync(url);
            return await HandleResponse<List<CurrencyNetworkDto>>(response);
        }

        public async Task<ExchangeRate> GetExchangeRateAsync(string fromCurrency, string toCurrency, decimal amount)
        {
            var endpoint = _config.BaseAddress+$"rate?from={fromCurrency}&to={toCurrency}&amount={amount}";
            var response = await _httpClient.GetAsync(endpoint);
            return await HandleResponse<ExchangeRate>(response);
        }

        public async Task<CreateTransactionResponse> CreateExchangeTransactionAsync(CreateTransactionRequest request = null)
        {
            request = request ?? new CreateTransactionRequest();
            var content = new StringContent(JsonConvert.SerializeObject(request));
            var response = await _httpClient.PostAsync(_config.BaseAddress+"transactions", content);
            return await HandleResponse<CreateTransactionResponse>(response);
        }

        public async Task<TransactionResponse> GetTransactionStatusAsync(string transactionId)
        {
            var response = await _httpClient.GetAsync(_config.BaseAddress+$"transactions/{transactionId}");
            return await HandleResponse<TransactionResponse>(response);
        }

        /// <summary>
        /// List of transaction history
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TransactionStatus> GetTransactionsAsync(TransactionQueryParameters request = null)
        {
            request = request ?? new TransactionQueryParameters { };
            var response = await _httpClient.GetAsync(_config.BaseAddress+$"transactions?page={request.Page}&size={request.Size}");
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
            try
            {
                return JsonConvert.DeserializeObject<T>(content);
            }
            catch (Exception e)
            {
                var obj = JsonConvert.DeserializeObject<ApiResponse<T>>(content);
                throw new ExolixApiException(obj?.Error);
            }
        }
    }
}
