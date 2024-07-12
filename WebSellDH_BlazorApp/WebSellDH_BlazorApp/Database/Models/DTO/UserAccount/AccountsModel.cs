using WebSellDH_BlazorApp.Database.DataModel;
namespace WebSellDH_BlazorApp.Database.Models.DTO.UserAccount
{
    public class AccountsModel : BaseDateEntity
    {
        public string? UserName { get; set; }

        public decimal? Balance { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Role { get; set; }

        public string? Display { get; set; }

        public int? OrderCount { get; set; }
    }
}
