using Canducci.SoftDelete.Extensions;
using CslAppSoftDelete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CslAppSoftDelete.Maps
{
    public class PeopleMap : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            builder.ToTable("People");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .UseIdentityColumn();
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.DeletedAt)
                .HasDefaultValue(null);
            builder.HasQueryFilterSoftDeleteDateTime();
        }
    }
}
