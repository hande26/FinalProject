using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    //burada EntitiyFrameworke bağımlı olmadığı için hiç bir değikklik yok.
    public class ProductManager : IProductService
    {
        //Bir iş sınıfı başka sınıfları new lemez.-İnjecyion
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal; 
        }


        //İŞ KODLARI
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }



        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId == id);//her p için onun category id si benim gönderdiğime eşitse bunu al.

        }



        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice >= min  && p.UnitPrice <= max);
                
        }
    }
}
