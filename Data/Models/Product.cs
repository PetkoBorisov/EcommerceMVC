using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Data.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int SubcategoryId { get; set; }
        public string Description { get; set; }

        public string Highlights { get; set; }

        public string Details { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }
        public Subcategory Subcategory { get; set; }
    }
}
