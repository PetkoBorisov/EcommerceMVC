using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Data.Models
{
    public class Subcategory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubcategoryId { get; set; }
       public string Name { get; set; }
        
       public int CategoryId { get; set; }
       public Category Category { get; set; }
    }
}
