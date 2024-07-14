using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSellDH_BlazorApp.Database.DataModel
{
    public class UserAccount : BaseDateEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [StringLength(150)]
        public string? UserName { get; set; }

        [Required]
        [StringLength(150)]
        public string? Password { get; set; }

        [StringLength(150)]
        public string? Email { get; set; }

        [StringLength(13)]
        public string? Phone { get; set; }

        [DefaultValue(0)]
        public int Role {  get; set; }

        [DefaultValue(false)]
        public bool Display { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? Balance { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }
    }
}
