using IdentityServer4;
using IdentityServer4.Models;

namespace ClothingShop.Server.Auth
{
    public class Config
    {
        public const string API_NAME = "ShopAPI";
        public const string IDENTITY_API_NAME = "";

        public static IEnumerable<IdentityResource> GetIdentityResources()
            => new List<IdentityResource>()
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
            };

        public static IEnumerable<ApiScope> GetApiScopes()
            => new List<ApiScope>()
            {
                new ApiScope(Scopes.INTERNAL, "An internal user that helps to manage the shop"),
                new ApiScope(Scopes.NORMAL, "An end user"),
            };

        public static IEnumerable<ApiResource> GetApiResources()
            => new List<ApiResource>()
            {
                new ApiResource(API_NAME, "API for Clothing Shop")
                {
                    UserClaims = new[] { "preferred_username", "name", "email" }
                },
                new ApiResource(IDENTITY_API_NAME, "Identity API")
            };

        public static IEnumerable<Client> GetClients()
            => new List<Client>()
            {
                new Client
                {
                    ClientId = "ClothingShop.Server",
                    ClientName = "Clothing Shop's Server",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowOfflineAccess = false,
                    RefreshTokenUsage = TokenUsage.OneTimeOnly,
                    RequireClientSecret = false,
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        Scopes.NORMAL
                    }
                },
                new Client
                {

                }
            };
    }
}
