using ACME.Database.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACME.Database.EntityFramework.Configuration;

internal class ReviewConfiguration : IdentityConfiguration<Review>
{
    public override void Configure(EntityTypeBuilder<Review> builder)
    {
        base.Configure(builder);
        builder.Navigation(r => r.Product).AutoInclude();
        builder.Navigation(r=>r.Reviewer).AutoInclude();    
    }
}
