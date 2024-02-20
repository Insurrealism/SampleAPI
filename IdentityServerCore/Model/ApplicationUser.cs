using Microsoft.AspNetCore.Identity;

namespace IdentityServerCore.Model
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
    }
}
