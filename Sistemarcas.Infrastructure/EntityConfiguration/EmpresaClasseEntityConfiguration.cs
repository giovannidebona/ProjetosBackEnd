using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class EmpresaClasseEntityConfiguration : IEntityTypeConfiguration<Empresas_Classes>
    {
        public void Configure(EntityTypeBuilder<Empresas_Classes> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Empresa)
                .WithMany()
                .HasForeignKey(d => d.Empresaid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.ClasseItem)
               .WithMany()
               .HasForeignKey(d => d.Classeitemid)
               .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Empresas_Classes");
        }
    }
}