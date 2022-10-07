using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class UsuarioEntityConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Pessoa)
                .WithMany()
                .HasForeignKey(d => d.Pessoa_id)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Usuario");
        }
    }
}
