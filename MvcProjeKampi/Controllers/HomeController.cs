using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{

    //bu metotların mutlaka view tarafında karşılığı vardır.
    public class HomeController : Controller
    {
        //Listeleme işlemi için kullanılır.
        public ActionResult Index()
        {
            return View();
        }
        //hakkında
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //iletisim
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            //Sayfaya mesaj taşıyor.
            return View();
        }
        public ActionResult Test()
        {
            return View();
            //geriye bir sayfa dönder.
        }
    }
}