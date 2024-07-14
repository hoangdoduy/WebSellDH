using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSellDH_BlazorApp.Database.DataModel
{
    public class ProductLink : BaseDateEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductLinkId { get; set; }

        public string? ProductLinkName { get; set; }

        public string? Url { get; set; }
    }
}
