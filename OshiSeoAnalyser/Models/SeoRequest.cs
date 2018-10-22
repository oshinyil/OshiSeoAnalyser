using System.Collections.Generic;
using System.Web.Mvc;

namespace OshiSeoAnalyser.Models
{
    public class SeoRequest
    {
        public bool IsUrl { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public List<SelectListItem> Options { get; set; }

        public SeoRequest()
        {
            Options = new List<SelectListItem>
            {
                new SelectListItem { Text = "Each word in the page", Value = "Page" },
                new SelectListItem { Text = "Each word in meta tags", Value = "MetaTag" },
                new SelectListItem { Text = "External links", Value = "ExternalLink" }
            };
        }
    }
}