using CompositeInCore.Models;
using CompositeInCore.Models.Context;
using CompositeInCore.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CompositeInCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataBaseContext context;
        public HomeController(ILogger<HomeController> logger, DataBaseContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var menus=context.categoryComponents.ToList();
            string result = "";
            foreach (var menu in menus.Where(p=>p.GetType()==typeof(CategoryItem))) //برای اضافه مزذن محصول این فور ایچ رو روی کتگوری ایتم میزارم
            {
                context.products.Add(new Product // اگه اون بالا رو پروداکت بزاریم لیست درست لود میشه ولی نمیشه اینجوری محصول ادد کرد
                {
                    Name = menu.Name,
                    categoryItem=menu as CategoryItem
                });
                result += menu.Print();
            }
            return View("Index",result);
        }
        public IActionResult TempData()
        {
            var product = new Category("محصولات");
            var testItem = new CategoryItem("موبایل", "Https://mobile.com/");
            product.Add(testItem);
            product.Add(new CategoryItem("لب تاپ", "https://lobtop.com"));
            product.Add(new CategoryItem("لوازم جانبی", "https://lavazamjanebi.com"));
            product.Add(new CategoryItem("کتاب", "https://ketab.com"));
            context.categoryComponents.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
