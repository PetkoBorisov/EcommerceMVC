using EcommerceMVC.Data.Models;

namespace EcommerceMVC.Models.ProductVariants
{
    public class VariantFormModel
    {
        
      
        public int ProductId { get; set; }

        public decimal Price { get; set; }

        public int ColorId { get; set; }

        public string FsImage1Url { get; set; }     
        public string FsImage2Url { get; set; }
        public string HsImage1Url { get; set; }
        public string HsImage2Url { get; set; }
        public int SizeId { get; set; }

        public float ReviewScore { get; set; }

        public DateTime CreatedDate { get; set; }

     
    }
}
