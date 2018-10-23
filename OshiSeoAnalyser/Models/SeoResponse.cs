using System.Collections.Generic;

namespace OshiSeoAnalyser.Models
{
    public class SeoResponse
    {
        public string Text { get; set; }
        public IDictionary<string, int> WordOccurences { get; set; }
    }
}