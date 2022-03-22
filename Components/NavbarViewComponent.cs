using EcommerceMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Components
{
    public class NavbarViewComponent:ViewComponent
    {
        public StoreDbContext _context;
        public NavbarViewComponent(StoreDbContext context)
        {
                _context = context;
          
        }
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {

            var data = _context.Categories.Include(x=>x.Subcategories).ThenInclude(x=>x.ProductTypes).ToList();
            
       
            
            return View(data);
        }


    }
}
