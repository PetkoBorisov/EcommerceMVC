using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Data.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int ProductTypeId { get; set; }
        public string Description { get; set; }

        public string Highlights { get; set; }

        public string Details { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }
        public ProductType ProductType { get; set; }

        public List<ProductVariant> ProductVariants { get; set; }
    }
}
