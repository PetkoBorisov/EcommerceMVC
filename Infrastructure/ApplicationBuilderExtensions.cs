using EcommerceMVC.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
           this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();
            var data = scopedServices.ServiceProvider.GetService<StoreDbContext>();
            data.Database.Migrate();
            return app;
        }
       

    }
}
