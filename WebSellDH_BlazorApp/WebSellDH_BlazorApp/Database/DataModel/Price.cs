using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSellDH_BlazorApp.Database.DataModel
{
    public class Price : BaseDateEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PriceId { get; set; }

        [Required]
        public string? PriceName { get; set; }

        [Required]
        public int PriceDay { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Balance { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
