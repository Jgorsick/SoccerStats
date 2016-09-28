using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats
{

    public class SentimentResponse
    {
        [JsonPropertyName(PropertyName = "documents")]
        public List<Sentiment> Sentiments { get; set; }
    }

    public class Sentiment
    {
        [JsonPropertyName(PropertyName = "id")]
          public string Id { get; set; }
        [JsonPropertyName(PropertyName = "score")]
        public string Score { get; set; }
    }

}
