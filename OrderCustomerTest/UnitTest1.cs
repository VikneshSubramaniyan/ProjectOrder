using Microsoft.AspNetCore.Mvc;
using OrderProj.Controllers;
using OrderProj.Model;
using System;
using Xunit;

namespace OrderCustomerTest
{
    public class UnitTest1
    {
        //private OrderDBContext _context;
        private readonly OrderDBContext _context;

        
        [Fact]
        public async void Task_GetEmail_Return_OkResult()
        {
            var id = "user@example.com";
            //Arrange  
            var controller = new CustomersController(_context);
            //var customer = await _context.Customers.FindAsync(id);
            //var id = "user@example.com";

            //Act  
            //var data = await _context.controller(id);
            var customer = await controller.GetCustomer(id);
            //Assert  
            Assert.IsType<OkObjectResult>(customer);
        }
    }
}
