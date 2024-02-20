using IdentityServerCore;
using IdentityServerCore.Data;
using IdentityServerCore.DbInit;
using IdentityServerCore.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddIdentityServer()
                .AddInMemoryIdentityResources(IdentityConfigs.IdentityResources)
                .AddInMemoryApiScopes(IdentityConfigs.ApiScopes)
                .AddInMemoryApiResources(IdentityConfigs.ApiResources)
                .AddInMemoryClients(IdentityConfigs.Clients)
                .AddAspNetIdentity<ApplicationUser>()
                .AddDeveloperSigningCredential();
builder.Services.AddScoped<IDbInitializer, DbInitializer>();

var app = builder.Build();

//SeedDatabase();
app.UseIdentityServer();
//app.UseAuthorization();
app.MapGet("/", () => "Hello World!");

app.Run();


void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
        dbInitializer.Initialize();
    }
}