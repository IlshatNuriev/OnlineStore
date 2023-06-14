using Microsoft.AspNetCore.Identity;

namespace OnlineStore_Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
