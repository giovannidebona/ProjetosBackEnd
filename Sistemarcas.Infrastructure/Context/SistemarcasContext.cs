using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistemarcas.Domain.Models;
using Sistemarcas.Infrastructure.EntityConfiguration;

namespace Sistemarcas.Infrastructure.Context
{
    public class SistemarcasContext : DbContext
    {
        public SistemarcasContext(DbContextOptions<SistemarcasContext> options) : base(options)
        {

        }

        public DbSet<Cargos> Cargos { get; set; }
        public DbSet<Anexos> Anexos { get; set; }
        public DbSet<Cidades> Cidades { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Classes_Itens> Classes_Itens { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClientesEmpresas> ClientesEmpresas { get; set; }
        public DbSet<Cnaes> Cnaes { get; set; }
        public DbSet<Contas> Contas { get; set; }
        public DbSet<Contas_Parcelas> Contas_Parcelas { get; set; }
        public DbSet<Convenios> Convenios { get; set; }
        public DbSet<Correspondentes> Correspondentes { get; set; }
        public DbSet<CustosIndividuais> CustosIndividuais { get; set; }
        public DbSet<Despachos> Despachos { get; set; }
        public DbSet<Despachos_Detalhes> Despachos_Detalhes { get; set; }
        public DbSet<Empresas> Empresas { get; set; }
        public DbSet<Empresas_Classes> Empresas_Classes { get; set; }
        public DbSet<Empresas_Cnaes> Empresas_Cnaes { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<Estudo_Viabilidade> Estudo_Viabilidade { get; set; }
        public DbSet<Estudo_Viabilidade_Marcas> Estudo_Viabilidade_Marcas { get; set; }
        public DbSet<Estudo_Viabilidade_Marcas_Itens> Estudo_Viabilidade_Marcas_Itens { get; set; }
        public DbSet<FormasPagamento> FormasPagamento { get; set; }
        public DbSet<GruposPermissoes> GruposPermissoes { get; set; }
        public DbSet<GruposPermissoesDetalhes> GruposPermissoesDetalhes { get; set; }
        public DbSet<Instituicoes> Instituicoes { get; set; }
        public DbSet<LogErros> LogErros { get; set; }
        public DbSet<Log_OrdemServico> Log_OrdemServico { get; set; }
        public DbSet<OpcoesGerais> OpcoesGerais { get; set; }
        public DbSet<Ordem_Servico_Colaboradores> Ordem_Servico_Colaboradores { get; set; }
        public DbSet<Ordem_Servico_Comissoes> Ordem_Servico_Comissoes { get; set; }
        public DbSet<OrdemServico_Patentes> OrdemServico_Patentes { get; set; }
        public DbSet<OrdemServico_Regras> OrdemServico_Regras { get; set; }
        public DbSet<Paises> Paises { get; set; }
        public DbSet<OrdemServico> Pedidos { get; set; }
        public DbSet<Pedidos_Anexos> Pedidos_Anexos { get; set; }
        public DbSet<Permissoes> Permissoes { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Pessoa_Comissao> Pessoa_Comissao { get; set; }
        public DbSet<Portes> Portes { get; set; }
        public DbSet<Processo> Processos { get; set; }
        public DbSet<Processos_Log_Situacoes> Processos_Log_Situacoes { get; set; }
        public DbSet<Processos_Marcas> Processos_Marcas { get; set; }
        public DbSet<Processos_Marcas_Classes_Itens> Processos_Marcas_Classes_Itens { get; set; }
        public DbSet<Processos_Movimentacoes> Processos_Movimentacoes { get; set; }
        public DbSet<Processos_Peticoes> Processos_Peticoes { get; set; }
        public DbSet<Processos_Servicos_Adicionais> Processos_Servicos_Adicionais { get; set; }
        public DbSet<Processos_Situacoes> Processos_Situacoes { get; set; }
        public DbSet<Ramos_De_Atividade> Ramos_De_Atividade { get; set; }
        public DbSet<Regras_Despachos_Fluxos> Regras_Despachos_Fluxos { get; set; }
        public DbSet<Regras_Despachos_Processos> Regras_Despachos_Processos { get; set; }
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<SituacoesRegistro> SituacoesRegistro { get; set; }
        public DbSet<SituacoesRegistro_Automatizacoes> SituacoesRegistro_Automatizacoes { get; set; }
        public DbSet<Situacoes_Regras> Situacoes_Regras { get; set; }
        public DbSet<Status_Propostas> Status_Propostas { get; set; }
        public DbSet<Tarefas> Tarefas { get; set; }
        public DbSet<Tarefas_Escritorio> Tarefas_Escritorio { get; set; }
        public DbSet<Tarefas_Responsaveis> Tarefas_Responsaveis { get; set; }
        public DbSet<TiposDespachos> TiposDespachos { get; set; }
        public DbSet<TiposTarefas> TiposTarefas { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioPermissao> UsuarioPermissao { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<Dev> Devs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=1J1KPH2\SQLEXPRESS;Database=Sistemarcas;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18,2)");
            }

            modelBuilder.ApplyConfiguration(new CargosEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ClasseItemEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ContasEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrdemServicoEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProcessosEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TarefaEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TarefaResponsavelEntityConfiguration());

            modelBuilder.ApplyConfiguration(new ClienteEmpresaEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CorrespondenteEntityConfiguration());
            modelBuilder.ApplyConfiguration(new DespachoDetalheEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EmpresaClasseEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EmpresaCnaeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EstudoViabilidadeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EstudoViabilidadeMarcaEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EstudoViabilidadeMarcaItemEntityConfiguration());
            modelBuilder.ApplyConfiguration(new InstituicaoEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrdemServicoColaboradorEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrdemServicoComissaoEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrdemServicoPatenteEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaComissaoEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProcessoPeticaoEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProcessoServicoAdicionalEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SituacoesRegistroAutomatizacoesEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TarefaEscritorioEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioEntityConfiguration());
            modelBuilder.ApplyConfiguration(new VendedorEntityConfiguration());

            modelBuilder.ApplyConfiguration(new DevsEntityConfiguration());
        }
    }
}
