using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{

    //Context : Db tabloları ile proje classlarını ilişkilendirir.
    public class NorthwindContext:DbContext
    {

        //bu metod proje hangi veri tabanı ile ilşkili onun belirtildiği yerdir.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //ovveride on tab*  
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-RDQ6ANA\SQLEXPRESS;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=True");


        }

        //Benim hangi classım hangi veri tabanı tablosuna bağlanacak.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
