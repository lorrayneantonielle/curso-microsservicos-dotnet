﻿using Microsoft.AspNetCore.Identity;

namespace GeekShopping.IndentityServer.Model
{
    public class AplicationUser : IdentityUser 
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
    }
}
