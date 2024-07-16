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
    }
}
