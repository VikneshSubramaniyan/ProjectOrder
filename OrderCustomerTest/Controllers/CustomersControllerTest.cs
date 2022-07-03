using Microsoft.EntityFrameworkCore;
using OrderProj.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCustomerTest.Controllers
{
    class CustomersControllerTest
    {
        //private PostRepository repository;
        public static DbContextOptions<OrderDBContext> dbContextOptions { get; }
        public static string connectionString = "Server=ABCD;Database=BlogDB;UID=sa;PWD=xxxxxxxxxx;";
        static CustomersControllerTest()
        {
            dbContextOptions = new DbContextOptionsBuilder<OrderDBContext>()
                .UseSqlServer(connectionString)
                .Options;
        }
    }
   /* public CustomersControllerTest()
    {
        var context = new OrderDBContext(dbContextOptions);
        DummyDb db = new DummyDb();
        db.Seed(context);
        PostRepository repository = new PostRepository(context);
    }*/
}
