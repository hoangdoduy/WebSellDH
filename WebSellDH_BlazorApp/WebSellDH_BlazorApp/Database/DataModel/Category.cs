using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSellDH_BlazorApp.Database.DataModel
{
    public class Category : BaseDateEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required]
        public string? CategoryName { get; set; }

        public string? CategoryContent { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}
