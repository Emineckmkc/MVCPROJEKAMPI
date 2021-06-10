using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;
        //yapıcı metot oluştu.
        public CategoryManager(ICategoryDal categoryDal)
        {
            
            this.categoryDal = categoryDal;
        }

      

        public void CategoryAdd(Category category)
        {
            
            categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            categoryDal.Update(category);
        }

        public Category GetByAd(int id)
        {
            return categoryDal.GetAd(x => x.CategoryID == id);
        }

        public Category GetByID(int id)
        {
            return categoryDal.Get(x=> x.CategoryID==id);
            
        }


        //  GenericRepository<Category> repo = new GenericRepository<Category>();

        //sırasıyla her bir işlem için o listeme ait metotlar tanımlanır mesela listele
        //public List<Category> GetAll()
        //{
        //    return repo.Listele();
        //}
        //public void CategoryAddBusinesLayer(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //    {
        //        //hata mesajı
        //    }
        //   // dışarıdan gelen parametre şartlara takılmazsa ekleme işlemi gerçekleştirilir.
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}
        public List<Category> GetList()
        {
            return categoryDal.Listele();
        }

        public int Status_difference()
        {
            int TStatus= categoryDal.List(x => x.CategoryStatus == true).Count();
            int FStatus = categoryDal.List(x => x.CategoryStatus == false).Count();
            int Fark = TStatus - FStatus;
            return Fark;

        }





        //public void CategoryBL(Category p)
        //{
        //    if(p.CategoryName==""||p.CategoryStatus==false||
        //        p.CategoryName.Length <= 2)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        categoryDal.Insert(p);
        //    }
        //}
    }
}
