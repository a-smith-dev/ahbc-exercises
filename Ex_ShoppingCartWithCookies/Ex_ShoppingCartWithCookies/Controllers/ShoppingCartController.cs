using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex_ShoppingCartWithCookies.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ex_ShoppingCartWithCookies.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IHttpContextAccessor _accessor;

        public ShoppingCartController(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public IActionResult Index()
        {
            var num = GetQuantity();

            var model = new ShoppingCart
            {
                Quantity = num
            };

            return View(model);
        }

        public IActionResult Submit()
        {
            var num = GetQuantity();
            num++;

            _accessor.HttpContext.Response.Cookies.Append("quantity", num.ToString());
            return RedirectToAction("Index");
        }

        public int GetQuantity()
        {
            var current = _accessor.HttpContext.Request.Cookies["quantity"];
            if (!int.TryParse(current, out var num))
            {
                num = 0;
            }

            return num;
        }
    }
}
