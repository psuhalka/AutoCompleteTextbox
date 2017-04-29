using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoCompleteTextbox.Models;

namespace AutoCompleteTextbox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetTopSuggestionWords(string searchString)
        {
            if (HttpContext.Application["ErrorReadingDictionary"] != null)
            {
                return Json("#ERROR LOADING DICTIONARY", JsonRequestBehavior.AllowGet);
            }
            else
            {
                WordDictionaryModel model = new WordDictionaryModel();
                return Json(model.GetTopSuggestionWords(searchString), JsonRequestBehavior.AllowGet);
            }
        }

    }
}