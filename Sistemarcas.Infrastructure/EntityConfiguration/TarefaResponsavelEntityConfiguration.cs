using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class TarefaResponsavelEntityConfiguration : IEntityTypeConfiguration<Tarefas_Responsaveis>
    {
        public void Configure(EntityTypeBuilder<Tarefas_Responsaveis> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Usuario)
                .WithMany()
                .HasForeignKey(d => d.Usuarioid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Tarefa)
                .WithMany()
                .HasForeignKey(c => c.Tarefaid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Tarefas_Responsaveis");
        }
    }
}
