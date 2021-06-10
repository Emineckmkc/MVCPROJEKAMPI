using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal headingDal;

        public HeadingManager(IHeadingDal  headingDal)
        {
            this.headingDal = headingDal;
        }

        public int GetBaslikSay(int id)
        {
             return headingDal.List(x => x.CategoryID == id).Count();
        }

        public int KategoriId()
        {
            var baslıklar = headingDal.Listele();

            var maxRepeated = baslıklar.GroupBy(s => s.CategoryID)
                         .OrderByDescending(s => s.Count())
                         .First().Key;
            return maxRepeated;
        }
    }
}
