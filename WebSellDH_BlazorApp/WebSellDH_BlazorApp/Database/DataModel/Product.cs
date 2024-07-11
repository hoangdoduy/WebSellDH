using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSellDH_BlazorApp.Database.DataModel
{
    public class Product : BaseDateEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        public string? ProductName { get; set; }

        [DefaultValue("1.0.0")]
        public string? ProductVersion { get; set; }

        public string? ProductContent { get; set; }

        [DefaultValue(false)]
        public bool Display { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [ForeignKey("ProductLink")]
        public int ProductLinkId { get; set; }
        public ProductLink? ProductLink { get; set; }

        public virtual ICollection<Price>? Prices { get; set; }
    }
}
