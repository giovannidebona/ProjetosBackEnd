using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class ContasEntityConfiguration : IEntityTypeConfiguration<Contas>
    {
        public void Configure(EntityTypeBuilder<Contas> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Numeroparcelas)
                .IsRequired();

            builder.ToTable("Contas");
        }
    }
}
