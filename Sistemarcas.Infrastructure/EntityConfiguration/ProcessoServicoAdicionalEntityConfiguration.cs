using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class ProcessoServicoAdicionalEntityConfiguration : IEntityTypeConfiguration<Processos_Servicos_Adicionais>
    {
        public void Configure(EntityTypeBuilder<Processos_Servicos_Adicionais> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.ProcessoMarca)
                .WithMany()
                .HasForeignKey(d => d.Processomarcaid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Servico)
                .WithMany()
                .HasForeignKey(d => d.Servicoid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Processos_Servicos_Adicionais");
        }
    }
}
