using EcommerceMVC.Data;
using EcommerceMVC.Data.Models;
using EcommerceMVC.Models;
using EcommerceMVC.Models.ProductVariants;
using EcommerceMVC.Services.ProductVariants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly StoreDbContext _context;
        private readonly IProductVariantService _variants;
        public AdminController(StoreDbContext context
            , IProductVariantService variants)
        {
            this._variants = variants;
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
        public IActionResult AddProduct(int id,Product product)
        {
            product.ProductTypeId = id;
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult AddProduct(int id)
        {

            var data = _context.ProductTypes.Include(x => x.Subcategory).ThenInclude(x => x.Category).Where(x=>x.ProductTypeId == id).SingleOrDefault();
            var subcategory = data.Subcategory;
            var category = subcategory.Category;

            ViewBag.Heading = $"Adding item to: {category.Name}>{subcategory.Name}>{data.Name}";
            ViewBag.Products = _context.Products.Where(x=>x.ProductTypeId == id);
            var brands = _context.Brands.ToList();
           
            ViewBag.Brands = brands;
            return View();
        }



        [HttpPost]
        public IActionResult AddProductVariant(int id, VariantFormModel data)
        {
            var fsImage1 = new Image
            {
                ImageUrl = data.FsImage1Url
            };

            var fsImage2 = new Image
            {
                ImageUrl = data.FsImage2Url
            };

            var hsImage1 = new Image
            {
                ImageUrl = data.HsImage1Url
            };

            var hsImage2 = new Image
            {
                ImageUrl = data.HsImage2Url
            };
            List<Image> images = new List<Image>();
            images.Add(fsImage1);
            images.Add(fsImage2);
            images.Add(hsImage1);
            images.Add(hsImage2);

            this._variants.Create(id,data.Price,data.ColorId
                ,images,data.SizeId,5,DateTime.UtcNow);
            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult AddProductVariant(int id)
        {

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


        [HttpPost]
        public IActionResult AddColor(Color color)
        {
            _context.Colors.Add(color);
            _context.SaveChanges();


            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult AddColor()
        {

            return View();
        }




        [HttpPost]
        public IActionResult AddSize(Size size)
        {
            _context.Sizes.Add(size);
            _context.SaveChanges();


            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult AddSize()
        {

            return View();
        }


    }
}
