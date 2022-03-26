using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Data.Models
{
    public class ProductVariant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductVariantId { get; set; }
        public int ProductId { get; set;}

        public decimal Price { get; set; }

       public int ColorId { get; set; }

      
        public int SizeId { get; set; }

        public float ReviewScore { get; set; }

        public DateTime CreatedDate { get; set; }

        public Product Product { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public List<Image> Images { get; set; }
    }
}
