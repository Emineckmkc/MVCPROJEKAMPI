using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
           HeadingManager hm = new HeadingManager( new EFHeadingDal());
           CategoryManager cm = new CategoryManager(new EFCategoryDal());
           WriterManager wm = new WriterManager(new EFWriterDal());
        public ActionResult Istatistik_index()
        {
            var category_values = cm.GetList().Count();
            ViewBag.KategoriSayisi = category_values;
            var baslikSayisi = hm.GetBaslikSay(13);
            ViewBag.baslikSayisi = baslikSayisi;
            var yazarSayisi = wm.GetList();
            ViewBag.yazarSayisi = yazarSayisi;

            int KategoriId = hm.KategoriId();
            var KategoriAdi = cm.GetByAd(KategoriId);
            ViewBag.KategoriAdi = KategoriAdi.CategoryName;

            int StatusFark = cm.Status_difference();
            ViewBag.StatusFark = StatusFark;
            return View();

        }
    }
}