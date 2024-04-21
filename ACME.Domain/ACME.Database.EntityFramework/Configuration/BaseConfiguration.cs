using ACME.Database.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACME.Database.EntityFramework.Configuration;

internal class IdentityConfiguration<T> : IEntityTypeConfiguration<T> where T: Entity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Timestamp)
              .IsRowVersion()
              .IsConcurrencyToken();
    }
}
