using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class OrdemServicoEntityConfiguration : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("Pedidos");
        }
    }
}
