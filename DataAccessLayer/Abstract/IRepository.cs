using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //CRUD operasyonları bir metot olarak tanımlayacağız.
        List<T> Listele();
        void Insert(T p);

        //sileceğimiz değeri bulacağız 
        T Get(Expression<Func<T, bool>> filter);
        T GetAd(Expression<Func<T, bool>> filter);
        void Update(T p);
        void Delete(T p);

        //şartlı liste
        List<T> List(Expression<Func<T, bool>> filter);

      //  Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;

    }
}
