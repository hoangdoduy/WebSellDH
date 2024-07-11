using System.ComponentModel.DataAnnotations.Schema;

namespace WebSellDH_BlazorApp.Database.DataModel
{
    public class BaseDateEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }
    }
}
