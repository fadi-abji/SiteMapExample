using Microsoft.AspNetCore.Identity;

namespace RazorLibrary.Models
{
    public class AppUser : IdentityUser
    {
        public List<IdentityRole> Roles { get; set; }
    }
}
