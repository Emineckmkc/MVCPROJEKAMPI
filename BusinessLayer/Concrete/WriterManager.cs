using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            this.writerDal = writerDal;
        }

        public int GetList()
        {
            int say= 0;
            var yazarlar = writerDal.Listele();
            foreach (var item in yazarlar)
            {
                if (item.WriterName.Contains("a") == true)
                {
                    say++;
                }
              
            }

          return say;
        }
    }
}

