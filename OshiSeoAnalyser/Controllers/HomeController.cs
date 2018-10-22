using OshiSeoAnalyser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            var result = new AnalyseResult
            {
                Text = model.IsUrl ? model.Url : model.Text
            };

            return PartialView("_AnalyseResult", result);
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