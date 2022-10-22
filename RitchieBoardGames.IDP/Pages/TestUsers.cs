// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using IdentityModel;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace RitchieBoardGames.IDP;

public class TestUsers
{
    public static List<TestUser> Users
    {
        get
        {
            var address = new
            {
                street_address = "One Hacker Way",
                locality = "Heidelberg",
                postal_code = 69118,
                country = "Germany"
            };
                
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                    Username = "Ivan",
                    Password = "password",
                    Claims = new List<Claim>
                    {
                        new Claim("role", "FreeUser"),
                        new Claim(JwtClaimTypes.GivenName, "Ivan"),
                        new Claim(JwtClaimTypes.FamilyName, "Panchenko")
                    }
                },
                new TestUser
                {
                    SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                    Username = "Masha",
                    Password = "password",
                    Claims = new List<Claim>
                    {
                        new Claim("role", "PayingUser"),
                        new Claim(JwtClaimTypes.GivenName, "Masha"),
                        new Claim(JwtClaimTypes.FamilyName, "Panchenko")
                    }
                },

                //new TestUser
                //{
                //    SubjectId = "1",
                //    Username = "alice",
                //    Password = "alice",
                //    Claims =
                //    {
                //        new Claim(JwtClaimTypes.Name, "Alice Smith"),
                //        new Claim(JwtClaimTypes.GivenName, "Alice"),
                //        new Claim(JwtClaimTypes.FamilyName, "Smith"),
                //        new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                //        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                //        new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                //        new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json)
                //    }
                //},
                //new TestUser
                //{
                //    SubjectId = "2",
                //    Username = "bob",
                //    Password = "bob",
                //    Claims =
                //    {
                //        new Claim(JwtClaimTypes.Name, "Bob Smith"),
                //        new Claim(JwtClaimTypes.GivenName, "Bob"),
                //        new Claim(JwtClaimTypes.FamilyName, "Smith"),
                //        new Claim(JwtClaimTypes.Email, "BobSmith@email.com"),
                //        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                //        new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                //        new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json)
                //    }
                //}
            };
        }
    }
}