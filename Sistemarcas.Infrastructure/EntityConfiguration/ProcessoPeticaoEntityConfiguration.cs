using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class ProcessoPeticaoEntityConfiguration : IEntityTypeConfiguration<Processos_Peticoes>
    {
        public void Configure(EntityTypeBuilder<Processos_Peticoes> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.OrdemServico)
                .WithMany()
                .HasForeignKey(d => d.Pedidoid)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Processo)
                .WithMany()
                .HasForeignKey(d => d.Processoid)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.TipoDespacho)
               .WithMany()
               .HasForeignKey(d => d.Tipodespachoid)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Processos_Peticoes");
        }
    }
}
