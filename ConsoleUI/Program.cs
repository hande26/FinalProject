using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;

public class Program
{
    public static void Main(string[] args)
    {


        //ProductManager productManager=new ProductManager(new InMemoryProductDal());//hangi veri yöntemi ile çalışılacağını söylemek lazım.

        //foreach (var item in productManager.GetAll()) 
        //{
        //    Console.WriteLine(item.ProductName);

        //}

        //Entitiy Framework ile aşağıdaki gibi bakıcaz.

        

        ProductManager productManager = new ProductManager(new EfProductDal());//sadece veriye erişim yöntemimiz değişti.

        foreach (var item in productManager.GetAll())
        {
            Console.WriteLine(item.ProductName);

        }

        Console.WriteLine("*****************************************");


        foreach (var item in productManager.GetAllByCategoryId(2))
        {
            Console.WriteLine(item.ProductName);

        }


        Console.WriteLine("*****************************************");


        foreach (var item in productManager.GetByUnitPrice(80,100))
        {
            Console.WriteLine(item.ProductName);

        }





    }
}