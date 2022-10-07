using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class EmpresaCnaeEntityConfiguration : IEntityTypeConfiguration<Empresas_Cnaes>
    {
        public void Configure(EntityTypeBuilder<Empresas_Cnaes> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Empresa)
                .WithMany()
                .HasForeignKey(d => d.Empresaid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Cnae)
               .WithMany()
               .HasForeignKey(d => d.Cnaeid)
               .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Empresas_Cnaes");
        }
    }
}