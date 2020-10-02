using Canducci.SoftDelete.Extensions;
using CslAppSoftDelete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CslAppSoftDelete.Maps
{
    public class SourceMap : IEntityTypeConfiguration<Source>
    {
        public void Configure(EntityTypeBuilder<Source> builder)
        {
            builder.ToTable("Source");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .UseIdentityColumn();
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.DeletedAt)
                .HasDefaultValue(false);
            builder.HasQueryFilterSoftDeleteBool();
        }
    }
}
