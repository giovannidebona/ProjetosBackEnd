using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class TarefaEntityConfiguration : IEntityTypeConfiguration<Tarefas>
    {
        public void Configure(EntityTypeBuilder<Tarefas> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Servico)
                .WithMany()
                .HasForeignKey(d => d.Servicoid)
                .IsRequired(false);

            builder.HasOne(c => c.TipoTarefa)
                .WithMany()
                .HasForeignKey(d => d.Tipotarefaid)
                .IsRequired(false);

            builder.HasOne(c => c.Usuario)
                .WithMany()
                .HasForeignKey(d => d.Usuarioid)
                .IsRequired(false);

            builder.HasOne(c => c.UsuarioCriador)
                .WithMany()
                .HasForeignKey(d => d.Usuariocriadorid);

            builder.HasOne(c => c.OrdemServico)
                .WithMany()
                .HasForeignKey(d => d.Pedidoid)
                .IsRequired(false);

            builder.HasOne(c => c.Despacho)
                .WithMany()
                .HasForeignKey(d => d.Despachoid)
                .IsRequired(false);


            builder.ToTable("Tarefas");
        }
    }
}
