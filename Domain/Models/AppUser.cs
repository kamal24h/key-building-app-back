// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Identity;

namespace Domain.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public partial class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayUserName { get; set; }

    }
}
