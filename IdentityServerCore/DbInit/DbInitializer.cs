using IdentityModel;
using IdentityServerCore.Data;
using IdentityServerCore.Model;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace IdentityServerCore.DbInit
{
    public class DbInitializer: IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userMgr;
        private readonly RoleManager<IdentityRole> _roleMgr;        

        public DbInitializer(ApplicationDbContext db, UserManager<ApplicationUser> userMgr, RoleManager<IdentityRole> roleMgr)
        {
            _db = db;
            _userMgr = userMgr;
            _roleMgr = roleMgr;
    }
        public void Initialize()
        {
            if (_roleMgr.FindByNameAsync(IdentityConfigs.Admin).Result == null)
            {
                _roleMgr.CreateAsync(new IdentityRole(IdentityConfigs.Admin)).GetAwaiter().GetResult();
                //_roleMgr.CreateAsync(new IdentityRole(IdentityConfigs.Admin)).GetAwaiter().GetResult();
            }

            ApplicationUser admin = new()
            {
                UserName = "admintest",
                Email= "admintest@mail.com",
                EmailConfirmed = true,
                PhoneNumber = "666",
                Name = "Admin Testing"
            };

            _userMgr.CreateAsync(admin, "Admin123*").GetAwaiter().GetResult();
            _userMgr.AddToRoleAsync(admin, IdentityConfigs.Admin).GetAwaiter().GetResult();

            
            var claims = _userMgr.AddClaimsAsync(admin, new Claim[]
            {
                new Claim(JwtClaimTypes.Name, admin.Name),
                new Claim(JwtClaimTypes.Role, IdentityConfigs.Admin)
            }).Result;
        }
    }
}
