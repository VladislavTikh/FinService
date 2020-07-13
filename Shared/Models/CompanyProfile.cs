using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinService.Shared.Models
{
    public class CompanyProfile
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("ipo")]
        public DateTime IPO { get; set; }

        [JsonProperty("marketCapitalization")]
        public decimal Capitalization { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("shareOutstanding")]
        public decimal ShareOutstandings { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("weburl")]
        public string Weburl { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("finnhubIndustry")]
        public string FinnHubIndustry { get; set; }
    }
}
