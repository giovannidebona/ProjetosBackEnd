using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class ClienteEmpresaEntityConfiguration : IEntityTypeConfiguration<ClientesEmpresas>
    {
        public void Configure(EntityTypeBuilder<ClientesEmpresas> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Cliente)
                .WithMany()
                .HasForeignKey(d => d.Clienteid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Empresa)
                .WithMany()
                .HasForeignKey(d => d.Empresaid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Cargo)
                .WithMany()
                .HasForeignKey(d => d.Cargoid)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("ClientesEmpresas");
        }
    }
}
