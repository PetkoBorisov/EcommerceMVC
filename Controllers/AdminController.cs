using EcommerceMVC.Data;
using EcommerceMVC.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly StoreDbContext _context;

        public AdminController(StoreDbContext context)
        {
            this._context = context;
        }


        public IActionResult Dashboard()
        {

            return View();
        }


        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();

            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult AddCategory()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddSubCategory(int id,Subcategory subcategory)
        {
            subcategory.CategoryId = id;
            _context.Subcategories.Add(subcategory);
            _context.SaveChanges();

            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult AddSubCategory(int id)
        {
            
            return View();
        }


        public IActionResult ShowCategories()
        {

            var data = _context.Categories.ToList();
            return View(data);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            

            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult AddProduct()
        {
            var options = _context.Subcategories.ToList();
            var brands = _context.Brands.ToList();
            ViewBag.Options = options;
            ViewBag.Brands = brands;
            return View();
        }

        [HttpPost]
        public IActionResult AddBrand(Brand brand)
        {
            _context.Brands.Add(brand);
            _context.SaveChanges();


            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult AddBrand()
        {
           
            return View();
        }


    }
}
