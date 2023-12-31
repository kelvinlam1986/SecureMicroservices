﻿using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;
using IdentityServer4;
using System.Security.Claims;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
          new Client[]
          {
                   new Client
                   {
                       ClientId = "movies_mvc_client",
                       ClientName = "Movie MVC Web App",
                       AllowedGrantTypes = GrantTypes.Hybrid,
                       RequirePkce = false,
                       AllowRememberConsent = false,
                       RedirectUris = new List<string>
                       {
                           "https://localhost:5002/signin-oidc"
                       },
                       PostLogoutRedirectUris = new List<string>
                       {
                           "https://localhost:5002/signout-callback-oidc"
                       },
                       ClientSecrets =
                       {
                           new Secret("secret".Sha256())
                       },
                       AllowedScopes = new List<string>
                       {
                           IdentityServerConstants.StandardScopes.OpenId,
                           IdentityServerConstants.StandardScopes.Profile,
                           IdentityServerConstants.StandardScopes.Email,
                            "movieAPI",
                            "roles"
                       }
                   }
          };

        public static IEnumerable<ApiScope> ApiScopes =>
           new ApiScope[]
           {
               new ApiScope("movieAPI", "Movie API")
           };

        public static IEnumerable<ApiResource> ApiResources =>
          new ApiResource[]
          {
               new ApiResource("movieAPI", "Movie API")
          };

        public static IEnumerable<IdentityResource> IdentityResources =>
          new IdentityResource[]
          {
              new IdentityResources.OpenId(),
              new IdentityResources.Profile(),
              new IdentityResources.Email(),
              new IdentityResource("roles", "Your role(s)", new List<string> { "role"})
          };

        public static List<TestUser> TestUsers =>
            new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "5BE86359-073C-434B-AD2D-A3932222DABE",
                    Username = "minhlam",
                    Password = "12345678x@X",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.GivenName, "minh"),
                        new Claim(JwtClaimTypes.FamilyName, "lam")
                    }
                }
            };
    }
}
