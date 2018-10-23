using System.Collections.Generic;

namespace OshiSeoAnalyser.Models
{
    public class SeoResponse
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public IDictionary<string, int> WordOccurences { get; set; }
    }
}