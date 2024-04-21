using ACME.Database.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACME.Database.EntityFramework.Configuration;

internal class ReviewerConfiguration : IdentityConfiguration<Reviewer>
{
    public override void Configure(EntityTypeBuilder<Reviewer> builder)
    {
        base.Configure(builder);
    }
}
