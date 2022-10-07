using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class InstituicaoEntityConfiguration : IEntityTypeConfiguration<Instituicoes>
    {
        public void Configure(EntityTypeBuilder<Instituicoes> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Pessoa)
                .WithMany()
                .HasForeignKey(d => d.Pessoa_id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Instituicoes");
        }
    }
}
