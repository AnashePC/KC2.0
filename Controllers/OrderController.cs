using Microsoft.AspNetCore.Mvc;
using KhumaloCraft02.Data;
using KhumaloCraft02.Models;
using KhumaloCraft02.Veiws;

namespace KhumaloCraft02.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                var order = new Order
                {
                    ItemName = model.ItemName,
                    Price = model.Price,
                    CustomerName = model.CustomerName,
                    CustomerEmail = model.CustomerEmail,
                    CustomerAddress = model.CustomerAddress
                };

                _context.Orders.Add(order);
                _context.SaveChanges();

                return RedirectToAction("Success");
            }

            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
