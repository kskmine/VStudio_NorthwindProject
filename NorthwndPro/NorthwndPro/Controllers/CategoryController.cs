using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwndPro.Entities.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwndPro.Controllers
{
    public class CategoryController : Controller
    {
        private NorthwindContext _nc;

        public CategoryController(NorthwindContext nc)
        {
            _nc = nc;
        }
        public IActionResult Index()
        {
            List<Category> categories = new List<Category>();
            categories = _nc.Categories.ToList();
            return View(categories);
        }
        public ActionResult Product(int id)
        {
            List<Product> products = new List<Product>();
            products = _nc.Products.Where(n => n.CategoryId == id).ToList();
            return View(products);
        }
    }
}
