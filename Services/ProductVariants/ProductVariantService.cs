using EcommerceMVC.Data;
using EcommerceMVC.Data.Models;
using EcommerceMVC.Services.ProductVariants;

namespace EcommerceMVC.Services.ProductVariants
{
    public class ProductVariantService : IProductVariantService
    {
        private readonly StoreDbContext _context;
        public ProductVariantService(StoreDbContext context)
        {
            this._context = context;
        }


        public int Create(int productId, decimal price, int colourId
           , List<Image> images, int sizeId, float reviewScore
           , DateTime createdDate)
        {
            var variantData = new ProductVariant
            {
                ProductId = productId,
                Price = price,
                ColorId = colourId,
                Images = images,
                SizeId = sizeId,
                ReviewScore = reviewScore,
                CreatedDate = createdDate
            };
            this._context.ProductVariants.Add(variantData);
            this._context.SaveChanges();
            return variantData.ProductVariantId;

        }

      
    }
}
