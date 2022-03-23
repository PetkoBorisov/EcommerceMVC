using EcommerceMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Controllers
{
    public class ProductsController : Controller
    {
        public StoreDbContext _context;
        public ProductsController(StoreDbContext context)
        {
            this._context = context;
        }


        public IActionResult Catalog(int ?id)
        {
            var data = _context.Products.Include(x=>x.ProductVariants).Include(x=>x.ProductType).ToList();
           
            if (id != null)
            {
                //model Should be filtered to the products with producttypeId == id
                data = data.Where(x => x.ProductType.ProductTypeId == id).ToList();
            }

            //else we should send all of the products to the view
            return View(data);
        }


        public IActionResult Overview(int? id)
        {
            var data = _context.ProductVariants.Include(x => x.Product).ThenInclude(x => x.ProductType).ThenInclude(x => x.Subcategory)
                .ThenInclude(x => x.Category).ToList();
                
            var productVariant = data.Where(x => x.ProductVariantId == id).FirstOrDefault();
         
            return View(productVariant);
        }




        public IActionResult Index()
        {
            return View();
        }
    }
}
