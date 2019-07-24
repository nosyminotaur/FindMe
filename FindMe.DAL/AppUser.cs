using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace FindMe.DAL
{
    public class AppUser : IdentityUser
    {
        public List<LoginProvider> LoginProviders;
    }
}
