using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FindMe.DAL.Context
{
    public class AuthContext : IdentityDbContext<AppUser>
    {
        public AuthContext(DbContextOptions<AuthContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var LoginTypeToStringConverter = new ValueConverter<List<LoginProvider>, string>(v => JsonConvert.SerializeObject(v), v => JsonConvert.DeserializeObject<List<LoginProvider>>(v));
            builder.Entity<AppUser>().Property(e => e.LoginProviders).HasConversion(LoginTypeToStringConverter);
            base.OnModelCreating(builder);
        }
    }
}
