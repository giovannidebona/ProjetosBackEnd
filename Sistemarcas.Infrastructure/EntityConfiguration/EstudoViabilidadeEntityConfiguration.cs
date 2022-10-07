using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class EstudoViabilidadeEntityConfiguration : IEntityTypeConfiguration<Estudo_Viabilidade>
    {
        public void Configure(EntityTypeBuilder<Estudo_Viabilidade> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Cliente)
                .WithMany()
                .HasForeignKey(d => d.Clienteid)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Empresa)
               .WithMany()
               .HasForeignKey(d => d.Empresaid)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.UsuarioCriador)
               .WithMany()
               .HasForeignKey(d => d.Usuario_criador_id)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.UsuarioResponsavel)
               .WithMany()
               .HasForeignKey(d => d.Usuario_responsavel_id)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.OrdemServico)
               .WithMany()
               .HasForeignKey(d => d.Ordem_servico_id)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.StatusProposta)
               .WithMany()
               .HasForeignKey(d => d.Status_proposta_id)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Estudo_Viabilidade");
        }
    }
}
