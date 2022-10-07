using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class SituacoesRegistroAutomatizacoesEntityConfiguration : IEntityTypeConfiguration<SituacoesRegistro_Automatizacoes>
    {
        public void Configure(EntityTypeBuilder<SituacoesRegistro_Automatizacoes> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.TiposDespachos)
                .WithMany()
                .HasForeignKey(d => d.Tipodespachoid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.SituacoesRegistro)
                .WithMany()
                .HasForeignKey(d => d.Situacaoregistroid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("SituacoesRegistro_Automatizacoes");
        }
    }
}
