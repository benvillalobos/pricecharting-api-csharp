using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChartingAPI
{
    class ListWrapper
    {
        //To unwrap the array of products when calling /api/products
        [JsonProperty("products")]
        public List<Product> Products { get; internal set; }
    }
}
