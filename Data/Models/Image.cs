using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Data.Models
{
    public class Image
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }
        public int ProductVariantId { get; set; }
        
        public string ImageUrl { get; set; }

        
        public ProductVariant ProductVariant { get; set; }
            
    }
}
