using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context cs = new Context();
        DbSet<T> _object;
        //T değerine karşılık gelecek sınıf
        //constructor
        public GenericRepository()
        {
            //sınıfın degeri contexte bağlı olarak gönderilen T değeri olacak.
            //ojbect isimli alanımız dışarıdan gönderilen entity ne ise o olacak.
            _object = cs.Set<T>();
        }
        public void Delete(T p)
        {
            _object.Remove(p);
            cs.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            //geriye filterdan gelen değeri dönder.
            return _object.SingleOrDefault();     
        }

        public T GetAd(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).FirstOrDefault();
          
        }

        public void Insert(T p)
        {
            _object.Add(p);
            cs.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
            //filterdan gelen değere göre listeleme yap.
        }
    



        public List<T> Listele()
        {
           
            return _object.ToList();
        }

        public void Update(T p)
        {
            cs.SaveChanges();
        }
    }
}
