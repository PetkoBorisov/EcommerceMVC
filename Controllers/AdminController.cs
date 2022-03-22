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
            var data = _context.Categories.ToList(); 
            ViewBag.Categories = data;
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
            var data = _context.Subcategories.Where(x => x.CategoryId == id).ToList();
            ViewBag.SubCategories = data;
            return View();
        }


        [HttpPost]
        public IActionResult AddProductType(int id, ProductType productType)
        {
            productType.SubcategoryId = id;
            _context.ProductTypes.Add(productType);
            _context.SaveChanges();

            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult AddProductType(int id)
        {
            var data = _context.ProductTypes.Where(x => x.SubcategoryId == id).ToList();
            ViewBag.ProductTypes = data;
            return View();
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
