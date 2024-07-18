using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//1:18:40    8. gün
namespace DataAccess.Concrete.EntitiyFramework
{
    //DataAccess üzerinde Manage NuGet Packages--->entitiyframeworkcore.sqlserver-->3.1.11 indirildi.
     
    public class EfProductDal : IProductDal
    {
        public void Add(Product entitiy)
        {
            //IDisposable pattern implementation of c#
            //C# da using içerisine yazılan değişkenler using bitince garbage collectore giderek beni bellekten at der.
            //Daha performanslı ürün geliştirmek için kullanılır,belleği hızlıca temizleme
            using (NorthwindContext context =new NorthwindContext())
            {

                var addedEntity = context.Entry(entitiy); //eklenecek veriyi git veri kaynağından bir tane nesne ile eşleştir.Ekleme olduğu için burda direk referansı yakaladık.
                addedEntity.State = EntityState.Added;//Eklenecek nesne 
                context.SaveChanges();


            }
        }




        public void Delete(Product entitiy)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entitiy); 
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }




        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
                //product döndürücek. ona single ordefault gönderiyoruz.
                //tek bir sonuç gelicek.


            }
        }






        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
             //Db setteki Product tablosuna yerleş.                     filtreli olarak getirmek istendiğinde 
             //select * from Products; döndürür.


            }




        }




        public void Update(Product entitiy)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entitiy); 
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }


    //normalde diğer classlar içinde aynı şekilde sadece değişkenler değişiyor nu durumda generic yapı kullanabilirizz!!
}
