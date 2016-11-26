using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceChartingAPI;
using System.Collections.Generic;

namespace APITests
{
    [TestClass]
    public class ClientTests
    {
        string ValidApiKey = "ReplaceWithValidAPIKey";
        [TestMethod]
        public void CorrectlySetsAPIKey()
        {
            string apikey = "Random API Key";
            PriceChartingApi client = new PriceChartingApi(apikey);
            Assert.AreEqual(apikey, client.ApiKey);
        }

        [TestMethod]
        public void CorrectlyParsesListOfProducts()
        {
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            List<Product> products = client.SearchProducts("earthbound").Result;
            Assert.AreEqual(products[0].Name, "EarthBound");
        }

        [TestMethod]
        public void CorrectlyParsesSingleProduct()
        {
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            Product product = client.SearchProduct("earthbound").Result;
            Assert.AreEqual(product.Name, "EarthBound");
        }
    }
}
