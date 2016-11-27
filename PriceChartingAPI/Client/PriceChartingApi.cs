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
        /// Searches for any products that match the query.
        /// </summary>
        /// <param name="query">The query string to search by.</param>
        /// <returns>A list of products matching the query.</returns>
        public async Task<List<Product>> SearchProductsByQuery(string query)
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
        /// Searches for a single product that matches the query.
        /// </summary>
        /// <param name="query">The query string to search by.</param>
        /// <returns>A single product.</returns>
        public async Task<Product> SearchProductByQuery(string query)
        {
            Url reqUrl = baseURL.AppendPathSegment("product");
            reqUrl.SetQueryParam("t", ApiKey);
            reqUrl.SetQueryParam("q", query);

            using (var client = this.client)
            {
                return await client.WithUrl(reqUrl).GetJsonAsync<Product>();
            }
        }

        /// <summary>
        /// Searches for a single product with a matching PriceCharting ID.
        /// </summary>
        /// <param name="id">The PriceCharting ID of the product to search for.</param>
        /// <returns>A single product.</returns>
        public async Task<Product> SearchProductByID(int id)
        {
            Url reqUrl = baseURL.AppendPathSegment("product");
            reqUrl.SetQueryParam("t", ApiKey);
            reqUrl.SetQueryParam("id", id);

            using (var client = this.client)
            {
                return await client.WithUrl(reqUrl).GetJsonAsync<Product>();
            }
        }

        /// <summary>
        /// Searches for a single product with a matching UPC.
        /// </summary>
        /// <param name="upc">The UPC of the product to search for.</param>
        /// <returns>A single product.</returns>
        public async Task<Product> SearchProductByUPC(string upc)
        {
            Url reqUrl = baseURL.AppendPathSegment("product");
            reqUrl.SetQueryParam("t", ApiKey);
            reqUrl.SetQueryParam("upc", upc);

            using (var client = this.client)
            {
                return await client.WithUrl(reqUrl).GetJsonAsync<Product>();
            }
        }
    }
}
