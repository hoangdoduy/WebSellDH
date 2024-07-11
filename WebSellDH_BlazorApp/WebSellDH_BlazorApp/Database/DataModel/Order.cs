using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSellDH_BlazorApp.Database.DataModel
{
    public class Order : BaseDateEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        public string? KeyAccess { get; set; }

        public DateTime DateEnd { get; set; }

        [DefaultValue(false)]
        public bool Display {  get; set; }

        [ForeignKey("UserAccount")]
        public int UserId { get; set; }
        public virtual UserAccount? UserAccount { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }

        [ForeignKey("Price")]
        public int PriceId { get; set; }
        public virtual Price? Price { get; set; }
    }
}
