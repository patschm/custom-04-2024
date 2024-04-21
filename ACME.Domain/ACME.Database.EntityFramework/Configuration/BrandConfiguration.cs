using ACME.Database.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACME.Database.EntityFramework.Configuration;

internal class BrandConfiguration : IdentityConfiguration<Brand>
{
    public override void Configure(EntityTypeBuilder<Brand> builder)
    {
        base.Configure(builder);
    }
}
