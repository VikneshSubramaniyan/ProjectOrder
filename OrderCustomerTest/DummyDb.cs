using OrderProj.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCustomerTest
{
    class DummyDb
    {
        public DummyDb()
        {
        }

        public void Seed(OrderDBContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.Customers.AddRange(
                new Customer() { Email = "user@example.com", Username= "string", Password= "string", Address= "string" },
                new Customer() { Email = "user1@example.com", Username = "string", Password = "string", Address = "string" }
                //new Customer() { Email = "vicky2@gmail.com", Username = "Viknesh", Password = "123", Address = "chennai" },
               // new Customer() { Email = "vicky3@gmail.com", Username = "Viknesh", Password = "123" ,Address = "chennai" }
            );

            context.Orders.AddRange(
                new Order() { OrderItem = "bike", OrderInfo = "redmi"},
                new Order() { OrderItem = "car", OrderInfo = "bmw" }
            );
            context.SaveChanges();
        }
    }
}
