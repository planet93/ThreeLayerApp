using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PricingTool.BLL;
using PricingTool.DAL.Context;

namespace PricingTool.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Class1 class1 = new Class1();
          var res = class1.GetAllClassifier();
            //var db = new DataContext();
            //var list = db.Classifier.GetAll().ToList();
            //var list = db.ClassifierType.AsEnumerable();
            //var list1 = list.ToList();
            return View();
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