using System.ComponentModel.DataAnnotations.Schema;

namespace WebSellDH_BlazorApp.Database.DataModel
{
    public class BaseDateEntity
    {
        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
