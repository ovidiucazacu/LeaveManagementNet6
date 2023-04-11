using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "4610g399-96f9-4723-c963-903425729d1k",
                    UserId = "4610e399-96d9-4723-a963-903425729a1b"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "4610g499-96f0-6723-d963-903425129v1k",
                    UserId = "8ca8d44d-8231-4d7c-9ee1-59169dde1ccd"
                });
        }
    }
}