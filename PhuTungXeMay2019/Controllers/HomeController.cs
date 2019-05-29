using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhuTungXeMay2019.Models;
namespace PhuTungXeMay2019.Controllers
{
    public class HomeController : Controller
    {
        private CsK23T2bEntities db = new CsK23T2bEntities();
        public ActionResult Index()
        {
            return View(db.SanPhams.ToList());
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