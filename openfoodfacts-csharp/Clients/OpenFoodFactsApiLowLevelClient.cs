
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenFoodFactsCSharp.Interfaces;
using OpenFoodFactsCSharp.Models;

namespace OpenFoodFactsCSharp.Clients
{
    /// <summary>
    /// A low-level client for OpenFoodFacts.
    /// </summary>
    public class OpenFoodFactsApiLowLevelClient : IOpenFoodFactsApiClient
    {
        /// <summary>
        /// The main API Url
        /// </summary>
        private const string ApiUrl = "https://world.openfoodfacts.org/api/v0";
        /// <summary>
        /// The HTTP client.
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Constructor with a given HTTP client.
        /// </summary>
        /// <param name="httpClient">The given HTTP client</param>
        /// <exception cref="ArgumentNullException">If the given <paramref name="httpClient"/> is <c>null</c></exception>
        public OpenFoodFactsApiLowLevelClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        /// <summary>
        /// Fetches an asynchronous task (of <see cref="ProductResponse"/>) for a given <paramref name="code"/>,
        /// </summary>
        /// <param name="code">The given code</param>
        /// <returns>The asynchronous task</returns>
        /// <exception cref="HttpRequestException">If no successful response was available for the given <paramref name="code"/></exception>
        public async Task<ProductResponse> FetchProductByCodeAsync(string code)
        {
            string requestUri = $"{ApiUrl}/product/{code}.json";
            var response = await _httpClient.GetAsync(requestUri);

            if (!response.IsSuccessStatusCode)
            {
                // Handle error or throw an exception
                throw new HttpRequestException($"Failed to fetch product by code: {code}");
            }

            string content = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<ProductResponse>(content);

            return product;
        }
    }
}
