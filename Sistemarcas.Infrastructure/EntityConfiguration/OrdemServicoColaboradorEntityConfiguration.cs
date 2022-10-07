using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class OrdemServicoColaboradorEntityConfiguration : IEntityTypeConfiguration<Ordem_Servico_Colaboradores>
    {
        public void Configure(EntityTypeBuilder<Ordem_Servico_Colaboradores> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.OrdemServico)
                .WithMany()
                .HasForeignKey(d => d.Ordem_servico_id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Pessoa)
                .WithMany()
                .HasForeignKey(d => d.Pessoa_id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Ordem_Servico_Colaboradores");
        }
    }
}
