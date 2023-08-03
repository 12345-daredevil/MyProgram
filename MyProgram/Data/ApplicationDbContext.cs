using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

//#nullable disable        // отключает свойство  nullable

namespace PlayGames.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppIdentityUser, IdentityRole, string>
    {
        //TODO разобраться с подключением
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var myGuid = Guid.NewGuid();

            base.OnModelCreating(builder);

            builder.Entity<AppIdentityUser>().HasData(
                new AppIdentityUser
                {
                    Email = "daredevil@gmail.com",
                    EmailConfirmed = true,
                    UserName = "daredevil@gmail.com",
                    NormalizedUserName = "daredevil@gmail.com",
                    NormalizedEmail = "daredevil@gmail.com",
                    LockoutEnd = null,
                    PasswordHash = "AQAAAAEAACcQAAAAEDYoyZCmuEuInTa2A02HFI7Yae2GXcE89f86l1TfVQXWbtlPDW5eYY9xgSg==",
                    SecurityStamp = "AUN2SAI7OAFGJGXZOQDC2FJVJT7KCI2P",
                    ConcurrencyStamp = "f76a2f99-b40f-494f-8ea6-cb11c28d8c4b",
                    TwoFactorEnabled = false,
                    AccessFailedCount = 0,
                    LockoutEnabled = true,
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    Id = myGuid.ToString(),
                    IdUser = 1
                });
        }


        //public ApplicationDbContext() => Database.EnsureCreated();

        //public ApplicationDbContext()
        //    : base("wpl24.u1136589_nav.u1136589_u1136589", throwIfV1Schema: false)
        //{
        //}

        //public static ApplicationDbContext Create()
        //{
        //    return new ApplicationDbContext();
        //}
    }
}