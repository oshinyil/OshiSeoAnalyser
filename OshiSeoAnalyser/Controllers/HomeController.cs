using OshiSeoAnalyser.Core;
using OshiSeoAnalyser.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace OshiSeoAnalyser.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new SeoRequest();
            return View(model);
        }

        [HttpPost]
        public ActionResult Analyse(SeoRequest model)
        {
            var response = new SeoResponse();

            try
            {
                var wordOccurences = model.IsUrl
                    ? SeoAnalyser.Analyse(model.Url, model.Options.Where(x => x.Selected).Select(x => x.Value).ToArray())
                    : SeoAnalyser.Analyse(model.Text);

                response.WordOccurences = wordOccurences;
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessage = ex.Message;
            }

            return PartialView("_AnalyseResult", response);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}