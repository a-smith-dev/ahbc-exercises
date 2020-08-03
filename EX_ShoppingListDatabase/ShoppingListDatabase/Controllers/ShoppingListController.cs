using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ShoppingListDatabase.Data;
using ShoppingListDatabase.Models;

namespace ShoppingListDatabase.Controllers
{
    public class ShoppingListController : Controller
    {
        private readonly CartContext _context;
        private ISession _session;

        public ShoppingListController(CartContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _session = accessor.HttpContext.Session;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.OrderBy(x => x.Name).ToListAsync();
            return View(products);
        }

        // need to add IActionResults for adding an item to the cart
        // and for viewing the full list.
        // probably need method to calculate the number of each product

        public async Task<IActionResult> AddItem(int? id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            List<Product> list;
            if (_session.Keys.Any(x => x == "Cart"))
            {
                list = JsonConvert.DeserializeObject<List<Product>>(_session.GetString("Cart"));
            }
            else
            {
                list = new List<Product>();
            }

            var product = await _context.Products.FindAsync(id);
            list.Add(product);
            _session.SetString("Cart", JsonConvert.SerializeObject(list));

            TempData["Success"] = $"Successfully added {product.Name} to cart!";
            return RedirectToAction("Index");
        }

        public IActionResult CheckOut()
        {
            List<Product> list;
            if (_session.Keys.Any(x => x == "Cart"))
            {
                list = JsonConvert.DeserializeObject<List<Product>>(_session.GetString("Cart"));
                _session.SetString("Cart", JsonConvert.SerializeObject(list));

                list = list.OrderBy(x => x.Name).ToList();
                ViewBag.Total = list.Sum(x => x.Price);

            }
            else
            {
                list = new List<Product>();
            }

            return View(list);
        }
    }
}
