// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace EShopper.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                   };


        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("resource_catalog"){Scopes={ "catalog_fullpermission", "catalog_readpermission" } },
            new ApiResource("resource_discount"){Scopes={ "discount_fullpermission" } },
            new ApiResource("resource_order"){Scopes={ "order_fullpermission" } },
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };


        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
               new ApiScope("catalog_fullpermission","Full Permission For Catalog Operations"),
               new ApiScope("catalog_readpermission","Reading Permissions For Catalog Service"),

               new ApiScope("discount_fullpermission","Full Permission For Discount Operations"),
               new ApiScope("order_fullpermission","Full Permission For Order Operations"),
               new ApiScope(IdentityServerConstants.LocalApi.ScopeName),
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {

                //admin
               new Client
               {
                 ClientId="EShopperAdmin",
                 ClientName="EShopper Admin User",
                 ClientSecrets={new Secret("secret".Sha256())},
                 AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                 AllowedScopes = { "catalog_fullpermission", "discount_fullpermission", "order_fullpermission", IdentityServerConstants.LocalApi.ScopeName, IdentityServerConstants.StandardScopes.Email, IdentityServerConstants.StandardScopes.OpenId, IdentityServerConstants.StandardScopes.Profile },
                 AccessTokenLifetime=600,
               },


               //visitor

               new Client
               {
                 ClientId="EShopperVisitorClient",
                 ClientName="EShopper Visitor User",
                 ClientSecrets={new Secret("secret".Sha256())},
                 AllowedGrantTypes = GrantTypes.ClientCredentials,
                 AllowedScopes = { "catalog_readpermission",IdentityServerConstants.LocalApi.ScopeName }
               }
            };
    }
}