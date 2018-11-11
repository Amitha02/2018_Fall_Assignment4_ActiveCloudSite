using System.ComponentModel.DataAnnotations;

namespace IEXTrading.Models
{
    public class RecommendationEquity
    {
        public int RecommendationEquityId { get; set; }
        public string LastDate { get; set; }
        public float LastOpen { get; set; }
        public float LastHigh { get; set; }
        public float LastLow { get; set; }
        public float LastClose { get; set; }
        public int LastVolume { get; set; }
        public float AveragePrice { get; set; }
        public double AverageVolume { get; set; }
        public float HighPrice { get; set; }
        public float LowPrice { get; set; }
        public string Recommendation { get; set; }
        public string Symbol { get; set; }
    }
}
