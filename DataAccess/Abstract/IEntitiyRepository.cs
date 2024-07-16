using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Generic yapı oluşturduk.
    //generic constrait (kısıt) oluşturuyoruz.
    //class : referans tip olmalı
    //IEntity : IEntity olabilir ve ya IEntity implemente eden bir nesne olabilir.
    //new() : IEntitiy soyut nesnesi kullanılamasın.
    public interface IEntitiyRepository<T> where T : class,IEntitiy,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null); //filtreli veya filtresiz olarak gelebilir anlamında tanımlama yaptık.
        //linq yapısı ile filtreleme yapabilmemizi sağlıyor.

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entitiy);

        void Update(T entitiy);

        void Delete(T entitiy);

        //List<T> GetAllByCategory(int Id);  yukarıda tanımlama yapınca bu metoda gerek kalmadı..







    }
}
