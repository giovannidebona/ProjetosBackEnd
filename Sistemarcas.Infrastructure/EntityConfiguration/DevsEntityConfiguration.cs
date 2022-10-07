using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class DevsEntityConfiguration : IEntityTypeConfiguration<Dev>
    {
        public void Configure(EntityTypeBuilder<Dev> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(200)
                .IsRequired(true);

            builder.Property(p => p.Login)
                .HasMaxLength(100)
                .IsRequired(true);

            builder.Property(p => p.Email)
               .HasMaxLength(200)
               .IsRequired(true);

            builder.Property(p => p.Squad)
                .HasMaxLength(100);

            builder.Property(p => p.Tag)
               .HasMaxLength(100);

            builder.Property(p => p.Avatar)
               .HasMaxLength(300);

            builder.HasIndex(e => e.Login)
                .IsUnique();

            builder.HasIndex(e => e.Email)
                .IsUnique();

            builder.HasIndex(e => e.Name);

            builder.ToTable("Dev");
        }
    }
}
