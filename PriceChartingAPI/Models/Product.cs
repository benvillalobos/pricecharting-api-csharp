using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChartingAPI
{
    /// <summary>
    /// Represents a product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Unique Identifier (ASIN) for this product on Amazon.com
        /// </summary>
        [JsonProperty("asin")]
        public string AmazonID { get; internal set; }

        /// <summary>
        /// Often referred to as Complete in Box (CIB). CIB price is what collectors sell the item for with the box and manual.
        /// The Buy and Sell prices are what PriceCharting recommends retailers buy and sell the CIB item for in their store and website.
        /// </summary>
        [JsonProperty("cib-price")]
        public string CompleteInBoxPrice { get; internal set; }

        /// <summary>
        /// The name of the console on which the item was released.
        /// </summary>
        [JsonProperty("console-name")]
        public string ConsoleName { get; internal set; }

        /// <summary>
        /// Unique Identifier (ePID) for this product on eBay and Half.com
        /// </summary>
        [JsonProperty("epid")]
        public string epid { get; internal set; }

        /// <summary>
        /// The price that GameStop charges for this game in "Pre-Owned" condition.
        /// The Trade price is what GameStop pays in cash for trade-in games.
        /// These prices are only available for consoles that GameStop sells or trades
        /// </summary>
        [JsonProperty("gamestop-price")]
        public string GameStopPrice { get; internal set; }

        /// <summary>
        /// The genre is a single category which describes the game.
        /// For example RPG, Fighting, Party, etc.
        /// </summary>
        [JsonProperty("genre")]
        public string Genre { get; internal set; }

        /// <summary>
        /// A unique identifier for every item in the price guide.
        /// Use as a reference point for future downloads or creating links between PriceCharting's data and another dataset
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; internal set; }

        /// <summary>
        /// The loose price is what collectors sell the item for without the box or manual.
        /// The Buy and Sell prices are what PriceCharting recommends retailers buy and sell the loose item for in their store or website.
        /// </summary>
        [JsonProperty("loose-price")]
        public string LoosePrice { get; internal set; }

        /// <summary>
        /// The New price is what collectors sell the item for when brand new and sealed.
        /// The Buy and Sell prices are what PriceCharting recommends retailers buy and sell the new item for in their store or website.
        /// </summary>
        [JsonProperty("new-price")]
        public string NewPrice { get; internal set; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        [JsonProperty("product-name")]
        public string Name { get; internal set; }

        /// <summary>
        /// The date the game was originally released.
        /// </summary>
        [JsonProperty("release-date")]
        public DateTime ReleaseDate { get; internal set; }

        /// <summary>
        /// The recommended price for retailers buying from a customer in CIB (complete in box) condition.
        /// </summary>
        [JsonProperty("retail-cib-buy")]
        public string RetailCompleteInBoxBuy { get; internal set; }

        /// <summary>
        /// The recommended price for retailers selling to a customer in CIB (complete in box) condition.
        /// </summary>
        [JsonProperty("retail-cib-sell")]
        public string RetailCompleteInBoxSell { get; internal set; }

        /// <summary>
        /// The recommended price for retailers buying from a customer in loose condition.
        /// </summary>
        [JsonProperty("retail-loose-buy")]
        public string RetailLooseBuy { get; internal set; }

        /// <summary>
        /// The recommended price for retailers selling to a customer in loose condition.
        /// </summary>
        [JsonProperty("retail-loose-sell")]
        public string RetailLooseSell { get; internal set; }

        /// <summary>
        /// The recommended price for retailers buying from a customer in brand new condition.
        /// </summary>
        [JsonProperty("retail-new-buy")]
        public string RetailNewBuy { get; internal set; }

        /// <summary>
        /// The recommended price for retailers selling to a customer in brand new condition.
        /// </summary>
        [JsonProperty("retail-new-sell")]
        public string RetailNewSell { get; internal set; }

        /// <summary>
        /// The items in your guide will include a UPC that helps you track the item and sell on some websites.
        /// For example, eBay uses UPC to identify products when selling on their site.
        /// UPCs may not be available for older consoles that came out before UPCs were created.
        /// </summary>
        [JsonProperty("upc")]
        public string UPC { get; internal set; }
    }
}
