using System.ComponentModel.DataAnnotations;
using WebSellDH_BlazorApp.Database.DataModel;

namespace WebSellDH_BlazorApp.Database.Models.DTO.UserAccount
{
    public class CreateAccount
    {
        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }

        public string? Phone {  get; set; }

        public int Role { get; set; } = 0;
    }
}
