using EcommerceMVC.Data;
using Microsoft.AspNetCore.Mvc;

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
            if (id != null)
            {
                //model Should be filtered to the products with producttypeId == id
            }

            //else we should send all of the products to the view
            return View();
        }




        public IActionResult Index()
        {
            return View();
        }
    }
}
