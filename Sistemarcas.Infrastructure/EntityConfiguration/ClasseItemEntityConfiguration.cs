using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class ClasseItemEntityConfiguration : IEntityTypeConfiguration<Classes_Itens>
    {
        public void Configure(EntityTypeBuilder<Classes_Itens> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Classes)
                 .WithMany()
                 .HasForeignKey(d => d.Classeid)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Classes_Itens");
        }
    }
}
