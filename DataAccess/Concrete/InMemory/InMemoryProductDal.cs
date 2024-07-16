using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal //Bellek üzerinde ürün ile ilgili veri erişim kodlarının yazılacağı yerdir.
    {
        //veri tabanı varmış gibi düşünücez.
        List<Product> _products; //bütün metodların dışında tanımladım.Global değişken alt çizgi ile tanımladık.
        public InMemoryProductDal()//sanki veri tabanından geliyormuş gibi simule ediyoruz.
        {
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitInStock=15},
                new Product{ProductId=1,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitInStock=3},
                new Product{ProductId=1,CategoryId=1,ProductName="Telefon",UnitPrice=1500,UnitInStock=2},
                new Product{ProductId=1,CategoryId=1,ProductName="Klavye",UnitPrice=150,UnitInStock=65},
                new Product{ProductId=1,CategoryId=1,ProductName="Fare",UnitPrice=85,UnitInStock=1 }
            };
        }



        public void Add(Product product)
        {
            _products.Add(product);
        }





        public void Delete(Product product) //Primary key kullanılır.
        {
            Product productToDelete=null;
            foreach (var p in _products)//liste içerisinde dolaşma
            {
                if(product.ProductId == p.ProductId)//benim gönderdiğim Id ile listedeki Id birbirine eşitse;
                {
                    productToDelete = p;//silinecek olan eleman bulundu.
                }
            }
             
            _products.Remove(productToDelete);


            //burada LINQ - Language Integrated Query devreye giriyor.
            //C# da Linq yapısı ile bu şekilde liste bazlı yapıları SQl gibi filtreleyebiliyoruz.

            productToDelete = _products.SingleOrDefault(p=>p.ProductId== product.ProductId);
            //bu product ı tek tek dolaşmaya yarar. p takma ismini verdir. Her p için p nin ProductId si benim gönderdiğim ProductId ye eşit mi?

            
        }


        public List<Product> GetAll()
        {
            return _products;
        }

        

        public void Update(Product product)
        {
            Product productToUpdate=null;
            //Gönderdiğim ürün Id sine sahip olan lisyedeki ürünü bul demek.
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;//update edilecek veri ile benim verdiğim veri olacak şekilde eşitlendi.
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitInStock = product.UnitInStock;


        }


        public List<Product> GetAllByCategory(int CategoryId)
        {
            return _products.Where(p=>p.CategoryId == CategoryId).ToList();
           //Where koşulu içindekş şarta uyan bütün elemanları yeni bir liste haline getirir be onu döndürür.


        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
