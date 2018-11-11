using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEXTrading.Models.ViewModel
{
    public class CompaniesEquities
    {
        public List<Company> Companies { get; set; }
        public Equity Current { get; set; }
        public string Dates { get; set; }
        public string Prices { get; set; }
        public string Volumes { get; set; }
        public float AvgPrice { get; set; }
        public double AvgVolume { get; set; }
        public float HighPrice { get; set; }
        public float LowPrice { get; set; }
        public string Recommendation { get; set; }

        public CompaniesEquities(List<Company> companies, Equity current, string dates, string prices, string volumes, float avgprice, double avgvolume)
        {
            Companies = companies;
            Current = current;
            Dates = dates;
            Prices = prices;
            Volumes = volumes;
            AvgPrice = avgprice;
            AvgVolume = avgvolume;
            HighPrice = 0;
            LowPrice = 0;
            Recommendation = null;
        }

        //This constructor set the Company Equities along with the Maximum High Price, Minimum High Price and Recommendation to Buy/Sell
        public CompaniesEquities(List<Company> companies, Equity current, string dates, string prices, string volumes, float avgprice, double avgvolume, float highPrice, float lowPrice, string recommendation)
        {
            Companies = companies;
            Current = current;
            Dates = dates;
            Prices = prices;
            Volumes = volumes;
            AvgPrice = avgprice;
            AvgVolume = avgvolume;
            HighPrice = highPrice;
            LowPrice = lowPrice;
            Recommendation = recommendation;
        }
    }
}
