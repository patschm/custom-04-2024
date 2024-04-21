using ACME.Database.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACME.Database.EntityFramework.Configuration;

internal class ProductConfiguration : IdentityConfiguration<Product>
{
    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        base.Configure(builder);
        builder.Navigation(p => p.ProductGroup).AutoInclude();
        builder.Navigation(p => p.Brand).AutoInclude();
        
    }
}
