using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Category tablosunun Data access Layeri
    public interface ICategoryDal:IEntitiyRepository<Category> //Generic yapı kurulduktan sonra çalışma tipi ile implemente ettik.
    {
        //Aşağıda kullanılan metod imzaları IProductDal da olduğu gibi sadece Product yerine Category kullanıyoruz.
        //Bu yaılara generic yapılar demiştik. Bu nedenle İnterface oluşturup onun üzerinden yürümeliyiz!!! (IEntitiyRepository)

        //List<Category> GetAll();  

        //void Add(Category category);

        //void Update(Category category);

        //void Delete(Category category);

        //List<Category> GetAllByCategory(int Id);




    }
}
