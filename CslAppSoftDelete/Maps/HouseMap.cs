using Canducci.SoftDelete.Extensions;
using CslAppSoftDelete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CslAppSoftDelete.Maps
{
    public class HouseMap : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.ToTable("House");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .UseIdentityColumn();
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.DeletedAt)
                .HasDefaultValue('N');
            builder.HasQueryFilterSoftDeleteChar();
        }
    }
}
