using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class OrdemServicoPatenteEntityConfiguration : IEntityTypeConfiguration<OrdemServico_Patentes>
    {
        public void Configure(EntityTypeBuilder<OrdemServico_Patentes> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.OrdemServico)
                .WithMany()
                .HasForeignKey(d => d.Ordemservicoid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("OrdemServico_Patentes");
        }
    }
}
