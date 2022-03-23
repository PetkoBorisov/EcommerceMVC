using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Data.Models
{
    public class ProductType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductTypeId { get; set; }
        public string Name { get; set; }

        public int SubcategoryId { get; set; }
        public  Subcategory Subcategory { get; set; }
        public List<Product> Products { get; set; }
    }
}
