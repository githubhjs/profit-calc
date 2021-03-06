﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ProfitCalc.ApiControl.TemplateClasses
{
    internal class BTerPairs
    {
        /*[JsonProperty("result")]
        public string Result { get; set; }*/

        [JsonProperty("last")]
        public string Last { get; set; }

        /*[JsonProperty("high")]
        public string High { get; set; }

        [JsonProperty("low")]
        public string Low { get; set; }

        [JsonProperty("avg")]
        public string Avg { get; set; }*/

        [JsonProperty("sell")]
        public string Sell { get; set; }

        [JsonProperty("buy")]
        public string Buy { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> Vols { get; set; }
    }

    internal class BTerOrders
    {
        /*[JsonProperty("result")]
        public string Result { get; set; }*/

        [JsonProperty("asks")]
        public double[][] Asks { get; set; }

        [JsonProperty("bids")]
        public double[][] Bids { get; set; }
    }
}
