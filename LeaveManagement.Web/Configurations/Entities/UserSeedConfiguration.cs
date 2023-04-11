using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "4610e399-96d9-4723-a963-903425729a1b",
                    Email = "dj_edy_2001@yahoo.com",
                    NormalizedEmail = "DJ_EDY_2001@YAHOO.COM",
                    NormalizedUserName = "DJ_EDY_2001@YAHOO.COM",
                    UserName = "dj_edy_2001@yahoo.com",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "01020376Edu$"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "8ca8d44d-8231-4d7c-9ee1-59169dde1ccd",
                    Email = "dj_edy_2002@yahoo.com",
                    NormalizedEmail = "DJ_EDY_2002@YAHOO.COM",
                    NormalizedUserName = "DJ_EDY_2002@YAHOO.COM",
                    UserName = "dj_edy_2002@yahoo.com",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "01020376Edu$"),
                    EmailConfirmed = true
                });
        }
    }
}