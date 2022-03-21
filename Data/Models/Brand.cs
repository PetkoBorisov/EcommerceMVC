using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Data.Models
{
    public class Brand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandId { get; set; }
        public string Name { get; set; }
    }
}
