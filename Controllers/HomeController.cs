using EcommerceMVC.Data;
using EcommerceMVC.Data.Models;
using EcommerceMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EcommerceMVC.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly StoreDbContext _context;
        public HomeController(StoreDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

          

            this._context.Categories.ToList().ForEach(category => Console.WriteLine(category.CategoryId));
            return View();
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