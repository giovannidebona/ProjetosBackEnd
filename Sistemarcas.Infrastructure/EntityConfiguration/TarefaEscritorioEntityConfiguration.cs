using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class TarefaEscritorioEntityConfiguration : IEntityTypeConfiguration<Tarefas_Escritorio>
    {
        public void Configure(EntityTypeBuilder<Tarefas_Escritorio> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.UsuarioResponsavel)
                .WithMany()
                .HasForeignKey(d => d.Usuarioresponsavelid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Tarefas_Escritorio");
        }
    }
}
