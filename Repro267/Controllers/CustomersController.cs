using System.Collections.Generic;
using System.Threading.Tasks;
using Repro267.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace Repro267.Controllers
{
    public class CustomersController : ODataController
    {
        [EnableQuery]
        public async Task<Customer> Post([FromBody] Customer customer)
        {
            return await Task.FromResult(new Customer
            {
                Id = 1,
                Name = "Customer 1",
                Orders = new List<Order>
                {
                    new Order { Id = 1, Amount = 7 },
                    new Order{ Id = 2, Amount = 13 }
                }
            });
        }
    }
}
