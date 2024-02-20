using Duende.IdentityServer.Models;

namespace IdentityServerCore
{
    public class IdentityConfigs
    {
        public const string Admin = "Administrator";
        public const string Customer = "Customer";

        public static IEnumerable<IdentityResource> IdentityResources =>
           new IdentityResource[]
           {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email()
           };

        public static IEnumerable<ApiResource> ApiResources =>
        new ApiResource[]
        {
            new ApiResource("api1")
            {
                Scopes = new List<string>{ "api.read", "api.write" },
                ApiSecrets = new List<Secret>{ new Secret("supersecret".Sha256()) }
            }
        };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("api.read", "Read data request to API"),
                new ApiScope("api.write", "Write data request to API"),
            };

        public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new Client
            {
                ClientId = "client",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("secret".Sha256()) },
                AllowedScopes = { "api.read" }
            },
        };
    }
}
