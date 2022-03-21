using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Data.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
