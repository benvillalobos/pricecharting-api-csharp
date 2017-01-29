using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceChartingAPI;
using System.Collections.Generic;

namespace APITests
{
    [TestClass]
    public class ClientTests
    {
        string ValidApiKey = "InsertKey";

        private void VerifyAPIKey()
        {
            if (ValidApiKey == "InsertKey")
            {
                throw new Exception("Don't forget to add your API Key");
            }
        }

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
            VerifyAPIKey();
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            List<Product> products = client.SearchProductsByQuery("earthbound");
            Assert.AreEqual(products[0].Name, "EarthBound");
        }

        [TestMethod]
        public void CorrectlyParsesListOfProductsAsync()
        {
            VerifyAPIKey();
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            List<Product> products = client.SearchProductsByQueryAsync("earthbound").Result;
            Assert.AreEqual(products[0].Name, "EarthBound");
        }

        [TestMethod]
        public void CorrectlyParsesSingleProduct()
        {
            VerifyAPIKey();
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            Product product = client.SearchProductByQuery("earthbound");
            Assert.AreEqual(product.Name, "EarthBound");
        }

        [TestMethod]
        public void CorrectlyParsesSingleProductAsync()
        {
            VerifyAPIKey();
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            Product product = client.SearchProductByQueryAsync("earthbound").Result;
            Assert.AreEqual(product.Name, "EarthBound");
        }

        [TestMethod]
        public void CorrectlySearchesByID()
        {
            VerifyAPIKey();
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            Product product = client.SearchProductByID(6910);
            Assert.AreEqual(product.Name, "EarthBound");
        }

        [TestMethod]
        public void CorrectlySearchesByIDAsync()
        {
            VerifyAPIKey();
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            Product product = client.SearchProductByIDAsync(6910).Result;
            Assert.AreEqual(product.Name, "EarthBound");
        }

        [TestMethod]
        public void SearchesByUPC()
        {
            VerifyAPIKey();
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            Product product = client.SearchProductByUPC("045496830434");
            Assert.AreEqual(product.Name, "EarthBound");
        }

        [TestMethod]
        public void SearchesByUPCAsync()
        {
            VerifyAPIKey();
            PriceChartingApi client = new PriceChartingApi(ValidApiKey);
            Product product = client.SearchProductByUPCAsync("045496830434").Result;
            Assert.AreEqual(product.Name, "EarthBound");
        }
    }
}
