using ACME.Database.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACME.Database.EntityFramework.Configuration;

internal class ProductGroupConfiguration : IdentityConfiguration<ProductGroup>
{
    public override void Configure(EntityTypeBuilder<ProductGroup> builder)
    {
        base.Configure(builder);
    }
}
