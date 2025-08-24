using Basic_MVC_Example.Models;
using Basic_MVC_Example.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Basic_MVC_Example.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Örnek müşteri
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Selin",
                LastName = "Özlük",
                Email = "selin@example.com"
            };

            // Örnek siparişler
            var orders = new List<Order>
            {
                new Order { Id = 18, ProductName = "Kolye",  Price = 350,  Quantity = 1 },
                new Order { Id = 12, ProductName = "Tişört", Price = 700,  Quantity = 1 },
                new Order { Id = 1,  ProductName = "Poster", Price = 1250, Quantity = 2 }
            };

            // ViewModel
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel); // Views/CustomerOrders/Index.cshtml
        }
    }
}
