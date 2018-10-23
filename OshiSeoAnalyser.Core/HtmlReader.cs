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

        public static string ExtractHtmlContent(string rawHtml)
        {
            // TODO: extract html content, 3rd party library can be used: Html Agility Pack
            return rawHtml;
        }

        public static string[] ExtractMetaTags(string rawHtml)
        {
            // TODO: extract meta tags from html
            return new string[] { "" };
        }
    }
}
