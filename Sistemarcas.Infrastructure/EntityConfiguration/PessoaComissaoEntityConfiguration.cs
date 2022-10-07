using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class PessoaComissaoEntityConfiguration : IEntityTypeConfiguration<Pessoa_Comissao>
    {
        public void Configure(EntityTypeBuilder<Pessoa_Comissao> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Pessoa)
                .WithMany()
                .HasForeignKey(d => d.Pessoa_id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.TipoDespacho)
                .WithMany()
                .HasForeignKey(d => d.Tipo_despacho_id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Pessoa_Comissao");
        }
    }
}
