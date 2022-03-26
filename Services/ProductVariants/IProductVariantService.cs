

using EcommerceMVC.Data.Models;

namespace EcommerceMVC.Services.ProductVariants
{
    public interface IProductVariantService
    {
        int Create(int productId, decimal price, int colourId
           , List<Image> images, int sizeId, float reviewScore
           , DateTime createdDate);
    }
}
