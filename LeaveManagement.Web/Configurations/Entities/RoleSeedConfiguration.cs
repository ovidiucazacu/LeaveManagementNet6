using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "4610g399-96f9-4723-c963-903425729d1k",
                Name = Roles.Administrator,
                NormalizedName = Roles.Administrator.ToUpper(),
            },
            new IdentityRole
            {
                Id = "4610g499-96f0-6723-d963-903425129v1k",
                Name = Roles.User,
                NormalizedName = Roles.User.ToUpper()
            });
        }
    }
}