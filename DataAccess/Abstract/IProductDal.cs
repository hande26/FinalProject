using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Product tablosunun Data Access Layeri
    public interface IProductDal :IEntitiyRepository<Product> //Generic yapı kurulduktan sonra çalışma tipi ile implemente ettik.
    {
        //Product ile ilgili veri tabanında yapacağım işlemlerin operasyonlarını içeren İnterface. EKLE/LİSTELE/SİLME/GÜNCELLEME

        //List<Product> GetAll();  
        //void Add(Product product);

        //void Update(Product product);

        //void Delete(Product product);

        //List<Product>GetAllByCategory(int CategoryId);

        //İlk başta yukarıdaki gibi tanımladık ama ICategoryDal da da aynı metodların kullanılıp sadece Parametrelerin değiştiğini gördük.
        //Bu durumlarda generic yapı kullanmalıyız;


    }
}
