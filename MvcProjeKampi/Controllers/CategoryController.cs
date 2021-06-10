using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager( new EFCategoryDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            //bütün kategori değerlerini getir
            var categoryvalues = cm.GetList();
           //geriye view döndür ama kategory values isimdeki değerleri de getir. BU veriler view'a aktarılır.
            return View(categoryvalues);
        }
        

        //sayfa yüklendiği zaman http get çalışır.
        [HttpGet]
        public ActionResult AddCategory()
        {

            return View();
        }
        

        //burası http post devreye girince çalışacaksın. Sayfada bir şey post edildiği zaman çalışılır.
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBusinesLayer(p);
            //geriye şu aksiyona doğru yönlendir

            //kategori eklerken hatanın devreye girmesi gerekiyor.
            CategoryValidatior categoryValidator = new CategoryValidatior();
            //parametreden gelen değerin doğruluk kontrolünü gerçekleştir.
            ValidationResult result = categoryValidator.Validate(p);
            if (result.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}