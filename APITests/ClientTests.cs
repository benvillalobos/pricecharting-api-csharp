using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceChartingAPI;
using System.Collections.Generic;

namespace APITests
{
    [TestClass]
    public class ClientTests
    {
        string ValidApiKey = "Valid API Key Goes Here";

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
            List<Product> products = client.SearchProductsByQuery("earthbound").Result;
            Assert.AreEqual(products[0].Name, "EarthBound");
        }

        [TestMethod]
        public void CorrectlyParsesSingleProduct()
        {
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            Product product = client.SearchProductByQuery("earthbound").Result;
            Assert.AreEqual(product.Name, "EarthBound");
        }

        [TestMethod]
        public void CorrectlySearchesByID()
        {
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            Product product = client.SearchProductByID(6910).Result;
            Assert.AreEqual(product.Name, "EarthBound");
        }

        [TestMethod]
        public void CorrectlySearchesByUPC()
        {
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            Product product = client.SearchProductByUPC("045496830434").Result;
            Assert.AreEqual(product.Name, "EarthBound");
        }
    }
}
