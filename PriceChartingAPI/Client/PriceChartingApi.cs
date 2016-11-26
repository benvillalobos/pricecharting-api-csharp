using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;

namespace PriceChartingAPI
{
    public class PriceChartingApi
    {
        private const string baseURL = "https://ae.pricecharting.com/api";

        /// <summary>
        /// Gets the API key used for the PriceCharting API
        /// </summary>
        public string ApiKey { get; }

        private FlurlClient client = new FlurlClient(baseURL);

        /// <summary>
        /// Creates a new instance of the PriceChartingClient class.
        /// </summary>
        /// <param name="apiKey">The API key to use for requests to the IGDB API.</param>
        public PriceChartingApi(string ApiKey)
        {
            this.ApiKey = ApiKey;
        }

        /// <summary>
        /// Searches by query for any product.
        /// </summary>
        /// <param name="query">The query string to search by.</param>
        /// <returns>A list of products matching the query.</returns>
        public async Task<List<Product>> SearchProducts(string query)
        {
            Url reqUrl = baseURL.AppendPathSegment("products");
            reqUrl.SetQueryParam("q", query);
            reqUrl.SetQueryParam("t", ApiKey);

            using (var client = this.client)
            {
                var list = await client.WithUrl(reqUrl).GetJsonAsync<ListWrapper>();
                return list?.Products.ToList() ?? new List<Product>();
            }
        }

        /// <summary>
        /// Searches by query for a single product.
        /// </summary>
        /// <param name="query">The query string to search by.</param>
        /// <returns>A single product.</returns>
        public async Task<Product> SearchProduct(string query)
        {
            Url reqUrl = baseURL.AppendPathSegment("product");
            reqUrl.SetQueryParam("q", query);
            reqUrl.SetQueryParam("t", ApiKey);

            using (var client = this.client)
            {
                return await client.WithUrl(reqUrl).GetJsonAsync<Product>();
            }
        }
    }
}
