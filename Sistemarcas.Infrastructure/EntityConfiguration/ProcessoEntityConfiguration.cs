using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class ProcessosEntityConfiguration : IEntityTypeConfiguration<Processo>
    {
        public void Configure(EntityTypeBuilder<Processo> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.OrdemServico)
                .WithMany()
                .HasForeignKey(d => d.Pedidoid)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder.HasOne(c => c.Processo_Marca)
                .WithMany()
                .HasForeignKey(d => d.Processofilhoid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Servico)
               .WithMany()
               .HasForeignKey(d => d.Servicoid)
               .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(c => c.SituacoesRegistro)
            //   .WithMany()
            //   .HasForeignKey(d => d.Situacaoregistroid)
            //   .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(c => c.Cliente)
            //  .WithMany()
            //  .HasForeignKey(d => d.Clienteid)
            //  .OnDelete(DeleteBehavior.Restrict)
            //  .IsRequired(false);

            //builder.HasOne(c => c.Empresa)
            //  .WithMany()
            //  .HasForeignKey(d => d.Empresaid)
            //  .OnDelete(DeleteBehavior.Restrict)
            //  .IsRequired(false);

            builder.ToTable("Processos");
        }
    }
}
