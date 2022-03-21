using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Data.Models
{
    public class ProductReview
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductReviewId { get; set; }

        public int IdentityUserId { get; set; }

        public float Score { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public IdentityUser User { get; set; }
    }
}
