using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Data.Models
{
    public class ProductVariant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductVariantId { get; set; }
        public int ProductId { get; set;}

        public decimal Price { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public float ReviewScore { get; set; }

        public DateTime CreatedDate { get; set; }

        public Product Product { get; set; }
    }
}
