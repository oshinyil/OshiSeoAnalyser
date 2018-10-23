using System.Net.Http;

namespace OshiSeoAnalyser.Core
{
    public class HtmlReader
    {
        public static string ReadRawHtml(string url)
        {
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync(url).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        return content.ReadAsStringAsync().Result;
                    }
                }
            }
        }
    }
}
