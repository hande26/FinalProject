using Business.Concrete;
using DataAccess.Concrete.InMemory;

public class Program
{
    public static void Main(string[] args)
    {
        

        ProductManager productManager=new ProductManager(new InMemoryProductDal());//hangi veri yöntemi ile çalışılacağını söylemek lazım.

        foreach (var item in productManager.GetAll()) 
        {
            Console.WriteLine(item.ProductName);

        }


    }
}