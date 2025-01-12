using Microsoft.AspNetCore.Identity;

namespace BuyOnline.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
