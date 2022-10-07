using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Sistemarcas.Infrastructure.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anexos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Processopeticaoid = table.Column<int>(type: "int", nullable: false),
                    Processoid = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<TimeSpan>(type: "time", nullable: false),
                    Despachoid = table.Column<int>(type: "int", nullable: false),
                    Despachodetalheid = table.Column<int>(type: "int", nullable: false),
                    Tarefaid = table.Column<int>(type: "int", nullable: false),
                    Clienteid = table.Column<int>(type: "int", nullable: false),
                    Categoriaanexoid = table.Column<short>(type: "smallint", nullable: false),
                    Pedidoid = table.Column<int>(type: "int", nullable: false),
                    Empresaid = table.Column<int>(type: "int", nullable: false),
                    Usuario_criador_id = table.Column<int>(type: "int", nullable: false),
                    Estudo_viabilidade_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidadeid = table.Column<int>(type: "int", nullable: false),
                    Datanascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Senhaportal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<short>(type: "smallint", nullable: false),
                    Rg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naturalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estadocivilid = table.Column<short>(type: "smallint", nullable: false),
                    Internacional = table.Column<bool>(type: "bit", nullable: false),
                    Primeiroacessoportal = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documentoprofissional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profissao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pre_cadastro = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cnaes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cnaes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clienteid = table.Column<int>(type: "int", nullable: false),
                    Empresaid = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Desconto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Vendedorid = table.Column<int>(type: "int", nullable: false),
                    Convenioid = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Numeroparcelas = table.Column<short>(type: "smallint", nullable: false),
                    Valorpermuta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pessoa_vendedor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contas_Parcelas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contaid = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Numeroparcela = table.Column<short>(type: "smallint", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Formapagamentoid = table.Column<int>(type: "int", nullable: false),
                    Datavencimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas_Parcelas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Convenios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresaid = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desconto = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convenios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustosIndividuais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustosIndividuais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Despachos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datarevista = table.Column<TimeSpan>(type: "time", nullable: false),
                    Numerorevista = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despachos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Razaosocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inscricaoestadual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidadeid = table.Column<int>(type: "int", nullable: false),
                    Endenreco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porteinpiid = table.Column<int>(type: "int", nullable: false),
                    Porteanvisaid = table.Column<int>(type: "int", nullable: false),
                    Portepoliciaid = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responsavel_legal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pre_cadastro = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormasPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GruposPermissoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposPermissoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GruposPermissoesDetalhes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Permissaoid = table.Column<int>(type: "int", nullable: false),
                    Grupopermissaoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposPermissoesDetalhes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Log_OrdemServico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ordemservicoid = table.Column<int>(type: "int", nullable: false),
                    Statusid = table.Column<short>(type: "smallint", nullable: false),
                    Acao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log_OrdemServico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogErros",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empresaid = table.Column<int>(type: "int", nullable: false),
                    Usuarioid = table.Column<int>(type: "int", nullable: false),
                    Datahora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogErros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpcoesGerais",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Smtpemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuarioemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senhaemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Portaemail = table.Column<int>(type: "int", nullable: false),
                    Sslemail = table.Column<bool>(type: "bit", nullable: false),
                    Emailsgerenciais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emailsloginportal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emailssenhaportal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emailsdadosportal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caminhoarquivosportal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keygoogle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcoesGerais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numeropedido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Situacao = table.Column<short>(type: "smallint", nullable: false),
                    Clienteid = table.Column<int>(type: "int", nullable: false),
                    Valorpedido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valordesconto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Empresaid = table.Column<int>(type: "int", nullable: false),
                    Geradoautomatico = table.Column<bool>(type: "bit", nullable: false),
                    Tipopedido = table.Column<int>(type: "int", nullable: false),
                    Datahora = table.Column<TimeSpan>(type: "time", nullable: false),
                    Vendedorid = table.Column<int>(type: "int", nullable: false),
                    Convenioid = table.Column<int>(type: "int", nullable: false),
                    Contaid = table.Column<int>(type: "int", nullable: false),
                    Valorpermuta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gerarnfe = table.Column<bool>(type: "bit", nullable: false),
                    Prazoautorizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prioridade = table.Column<short>(type: "smallint", nullable: false),
                    Despachoid = table.Column<int>(type: "int", nullable: false),
                    Calcularprazoservicos = table.Column<bool>(type: "bit", nullable: false),
                    Dataautorizacao = table.Column<TimeSpan>(type: "time", nullable: false),
                    Pessoa_vendedor_id = table.Column<int>(type: "int", nullable: false),
                    Valorliquido = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos_Anexos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomearquivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos_Anexos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Ordem = table.Column<short>(type: "smallint", nullable: false),
                    Codigopermissao = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidadeid = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Rg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Razao_social = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naturalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estadocivilid = table.Column<short>(type: "smallint", nullable: false),
                    Internacional = table.Column<bool>(type: "bit", nullable: false),
                    Documentoprofissional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profissao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datanascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inscricao_estadual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senhaportal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Primeiroacessoportal = table.Column<bool>(type: "bit", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Portes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processos_Log_Situacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Processoid = table.Column<int>(type: "int", nullable: false),
                    Situacaoid = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos_Log_Situacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processos_Situacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grupo = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos_Situacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ramos_De_Atividade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ramos_De_Atividade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regras_Despachos_Fluxos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Regra_id = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regras_Despachos_Fluxos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regras_Despachos_Processos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Regra_id = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regras_Despachos_Processos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<short>(type: "smallint", nullable: false),
                    Grupo = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Situacoes_Regras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condicao1_peticaoid = table.Column<int>(type: "int", nullable: false),
                    Condicao1_situacaoid = table.Column<int>(type: "int", nullable: false),
                    Condicao2_peticaoid = table.Column<int>(type: "int", nullable: false),
                    Condicao2_situacaoid = table.Column<int>(type: "int", nullable: false),
                    Condicao3_despachoid = table.Column<int>(type: "int", nullable: false),
                    Condicao3_situacaoid = table.Column<int>(type: "int", nullable: false),
                    Condicao3_dias = table.Column<int>(type: "int", nullable: false),
                    Condicao3_aposdias_situacaoid = table.Column<int>(type: "int", nullable: false),
                    Condicao4_despachoid = table.Column<int>(type: "int", nullable: false),
                    Condicao4_situacaoid = table.Column<int>(type: "int", nullable: false),
                    Condicao2_peticaoid2 = table.Column<int>(type: "int", nullable: false),
                    Usacondicao1 = table.Column<bool>(type: "bit", nullable: false),
                    Usacondicao2 = table.Column<bool>(type: "bit", nullable: false),
                    Usacondicao3 = table.Column<bool>(type: "bit", nullable: false),
                    Usacondicao4 = table.Column<bool>(type: "bit", nullable: false),
                    Usacondicao5 = table.Column<bool>(type: "bit", nullable: false),
                    Usacondicao6 = table.Column<bool>(type: "bit", nullable: false),
                    Usacondicao7 = table.Column<bool>(type: "bit", nullable: false),
                    Condicao5_situacaoid = table.Column<int>(type: "int", nullable: false),
                    Condicao6_situacaoid = table.Column<int>(type: "int", nullable: false),
                    Condicao7_peticaoid = table.Column<int>(type: "int", nullable: false),
                    Condicao7_situacaoid = table.Column<int>(type: "int", nullable: false),
                    Condicao7_situacaoid2 = table.Column<int>(type: "int", nullable: false),
                    Condicao7_peticaoid2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situacoes_Regras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SituacoesRegistro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grupo = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacoesRegistro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status_Propostas",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<short>(type: "smallint", nullable: false),
                    Ordem = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status_Propostas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDespachos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prazoordinario = table.Column<short>(type: "smallint", nullable: false),
                    Acao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<short>(type: "smallint", nullable: false),
                    Grupo = table.Column<short>(type: "smallint", nullable: false),
                    Custo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prazoextraordinario = table.Column<short>(type: "smallint", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Processosituacaoidincluir = table.Column<int>(type: "int", nullable: false),
                    Processosituacaoidautomatica = table.Column<int>(type: "int", nullable: false),
                    Alterarsituacaoaposprazo = table.Column<bool>(type: "bit", nullable: false),
                    Prazodiasalterarsituacao = table.Column<int>(type: "int", nullable: false),
                    Processosituacaoidautorizado = table.Column<int>(type: "int", nullable: false),
                    Processosituacaoidnaoautorizado = table.Column<int>(type: "int", nullable: false),
                    Custograndeporte = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Nomeicone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Corfundoicone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coricone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Taxa_pequeno_porte = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Taxa_grande_porte = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDespachos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposTarefas",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposTarefas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioPermissao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuarioid = table.Column<int>(type: "int", nullable: false),
                    Moduloid = table.Column<int>(type: "int", nullable: false),
                    Identidade = table.Column<int>(type: "int", nullable: false),
                    Permissaoid = table.Column<int>(type: "int", nullable: false),
                    Cadastradopor = table.Column<long>(type: "bigint", nullable: false),
                    Cadastradoem = table.Column<TimeSpan>(type: "time", nullable: false),
                    Modificadoem = table.Column<TimeSpan>(type: "time", nullable: false),
                    Modificadopor = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioPermissao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes_Itens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Classe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numerobase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Classeid = table.Column<int>(type: "int", nullable: false),
                    ClassesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes_Itens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Itens_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdemServico_Regras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Despachoid = table.Column<int>(type: "int", nullable: false),
                    Peticaoid_ordinario = table.Column<int>(type: "int", nullable: false),
                    Peticaoid_extraordinario = table.Column<int>(type: "int", nullable: false),
                    Peticaoid_ordinario2 = table.Column<int>(type: "int", nullable: false),
                    Peticaoid_extraordinario2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServico_Regras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Regras_Despachos_Despachoid",
                        column: x => x.Despachoid,
                        principalTable: "Despachos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientesEmpresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clienteid = table.Column<int>(type: "int", nullable: false),
                    Empresaid = table.Column<int>(type: "int", nullable: false),
                    Cargoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesEmpresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientesEmpresas_Cargos_Cargoid",
                        column: x => x.Cargoid,
                        principalTable: "Cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientesEmpresas_Clientes_Clienteid",
                        column: x => x.Clienteid,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientesEmpresas_Empresas_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empresas_Cnaes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresaid = table.Column<int>(type: "int", nullable: false),
                    Cnaeid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas_Cnaes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresas_Cnaes_Cnaes_Cnaeid",
                        column: x => x.Cnaeid,
                        principalTable: "Cnaes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresas_Cnaes_Empresas_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paisid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estados_Paises_Paisid",
                        column: x => x.Paisid,
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdemServico_Patentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ordemservicoid = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prazoautorizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServico_Patentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Patentes_Pedidos_Ordemservicoid",
                        column: x => x.Ordemservicoid,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Correspondentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pessoa_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Correspondentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Correspondentes_Pessoa_Pessoa_id",
                        column: x => x.Pessoa_id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instituicoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pessoa_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instituicoes_Pessoa_Pessoa_id",
                        column: x => x.Pessoa_id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ordem_Servico_Colaboradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ordem_servico_id = table.Column<int>(type: "int", nullable: false),
                    Pessoa_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordem_Servico_Colaboradores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ordem_Servico_Colaboradores_Pedidos_Ordem_servico_id",
                        column: x => x.Ordem_servico_id,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ordem_Servico_Colaboradores_Pessoa_Pessoa_id",
                        column: x => x.Pessoa_id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ordem_Servico_Comissoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ordem_servico_id = table.Column<int>(type: "int", nullable: false),
                    Pessoa_id = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordem_Servico_Comissoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ordem_Servico_Comissoes_Pedidos_Ordem_servico_id",
                        column: x => x.Ordem_servico_id,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ordem_Servico_Comissoes_Pessoa_Pessoa_id",
                        column: x => x.Pessoa_id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Cadastradopor = table.Column<long>(type: "bigint", nullable: false),
                    Modificadopor = table.Column<long>(type: "bigint", nullable: false),
                    Cadastradoem = table.Column<TimeSpan>(type: "time", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modificadoem = table.Column<TimeSpan>(type: "time", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<short>(type: "smallint", nullable: false),
                    Pessoa_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Pessoa_Pessoa_id",
                        column: x => x.Pessoa_id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pessoa_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendedores_Pessoa_Pessoa_id",
                        column: x => x.Pessoa_id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa_Comissao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pessoa_id = table.Column<int>(type: "int", nullable: false),
                    Tipo_despacho_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa_Comissao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoa_Comissao_Pessoa_Pessoa_id",
                        column: x => x.Pessoa_id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_Comissao_TiposDespachos_Tipo_despacho_id",
                        column: x => x.Tipo_despacho_id,
                        principalTable: "TiposDespachos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SituacoesRegistro_Automatizacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipodespachoid = table.Column<int>(type: "int", nullable: false),
                    Situacaoregistroid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacoesRegistro_Automatizacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SituacoesRegistro_Automatizacoes_SituacoesRegistro_Situacaoregistroid",
                        column: x => x.Situacaoregistroid,
                        principalTable: "SituacoesRegistro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SituacoesRegistro_Automatizacoes_TiposDespachos_Tipodespachoid",
                        column: x => x.Tipodespachoid,
                        principalTable: "TiposDespachos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empresas_Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresaid = table.Column<int>(type: "int", nullable: false),
                    Classeitemid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresas_Classes_Classes_Itens_Classeitemid",
                        column: x => x.Classeitemid,
                        principalTable: "Classes_Itens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresas_Classes_Empresas_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo_ibge = table.Column<int>(type: "int", nullable: false),
                    Estadoid = table.Column<int>(type: "int", nullable: false),
                    Populacao_2010 = table.Column<int>(type: "int", nullable: false),
                    Densidade_demo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gentilico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidades_Estados_Estadoid",
                        column: x => x.Estadoid,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estudo_Viabilidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clienteid = table.Column<int>(type: "int", nullable: false),
                    Empresaid = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Usuario_criador_id = table.Column<int>(type: "int", nullable: false),
                    Data_criacao = table.Column<TimeSpan>(type: "time", nullable: false),
                    Data_conclusao = table.Column<TimeSpan>(type: "time", nullable: false),
                    Usuario_responsavel_id = table.Column<int>(type: "int", nullable: false),
                    Parecer = table.Column<short>(type: "smallint", nullable: false),
                    Ordem_servico_id = table.Column<int>(type: "int", nullable: false),
                    Status_proposta_id = table.Column<short>(type: "smallint", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudo_Viabilidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estudo_Viabilidade_Clientes_Clienteid",
                        column: x => x.Clienteid,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estudo_Viabilidade_Empresas_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estudo_Viabilidade_Pedidos_Ordem_servico_id",
                        column: x => x.Ordem_servico_id,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estudo_Viabilidade_Status_Propostas_Status_proposta_id",
                        column: x => x.Status_proposta_id,
                        principalTable: "Status_Propostas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estudo_Viabilidade_Usuario_Usuario_criador_id",
                        column: x => x.Usuario_criador_id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estudo_Viabilidade_Usuario_Usuario_responsavel_id",
                        column: x => x.Usuario_responsavel_id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuarioid = table.Column<int>(type: "int", nullable: true),
                    Pedidoid = table.Column<int>(type: "int", nullable: false),
                    Processoid = table.Column<int>(type: "int", nullable: false),
                    Despachoid = table.Column<int>(type: "int", nullable: false),
                    Financeiroid = table.Column<int>(type: "int", nullable: false),
                    Dataprevisaotermino = table.Column<TimeSpan>(type: "time", nullable: false),
                    Datatermino = table.Column<TimeSpan>(type: "time", nullable: false),
                    Datainicio = table.Column<TimeSpan>(type: "time", nullable: false),
                    Usuariocriadorid = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Servicoid = table.Column<short>(type: "smallint", nullable: false),
                    Grupo = table.Column<short>(type: "smallint", nullable: false),
                    Prioridade = table.Column<short>(type: "smallint", nullable: false),
                    Codigotarefa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipotarefaid = table.Column<short>(type: "smallint", nullable: false),
                    Processo_peticaoid = table.Column<int>(type: "int", nullable: false),
                    Pendentetarefaid = table.Column<int>(type: "int", nullable: false),
                    Classeid = table.Column<int>(type: "int", nullable: false),
                    Clienteid = table.Column<int>(type: "int", nullable: false),
                    Empresaid = table.Column<int>(type: "int", nullable: false),
                    Transferencia = table.Column<bool>(type: "bit", nullable: false),
                    OrdemServicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarefas_Despachos_Despachoid",
                        column: x => x.Despachoid,
                        principalTable: "Despachos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tarefas_Pedidos_OrdemServicoId",
                        column: x => x.OrdemServicoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tarefas_Servicos_Servicoid",
                        column: x => x.Servicoid,
                        principalTable: "Servicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tarefas_TiposTarefas_Tipotarefaid",
                        column: x => x.Tipotarefaid,
                        principalTable: "TiposTarefas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tarefas_Usuario_Usuariocriadorid",
                        column: x => x.Usuariocriadorid,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tarefas_Usuario_Usuarioid",
                        column: x => x.Usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarefas_Escritorio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prioridade = table.Column<short>(type: "smallint", nullable: false),
                    Data_prazo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Usuarioresponsavelid = table.Column<int>(type: "int", nullable: false),
                    Data_abertura = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas_Escritorio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarefas_Escritorio_Usuario_Usuarioresponsavelid",
                        column: x => x.Usuarioresponsavelid,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estudo_Viabilidade_Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estudo_viabilidade_id = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Segmento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudo_Viabilidade_Marcas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estudo_Viabilidade_Marcas_Estudo_Viabilidade_Estudo_viabilidade_id",
                        column: x => x.Estudo_viabilidade_id,
                        principalTable: "Estudo_Viabilidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarefas_Responsaveis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuarioid = table.Column<int>(type: "int", nullable: false),
                    Tarefaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas_Responsaveis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarefas_Responsaveis_Tarefas_Tarefaid",
                        column: x => x.Tarefaid,
                        principalTable: "Tarefas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tarefas_Responsaveis_Usuario_Usuarioid",
                        column: x => x.Usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estudo_Viabilidade_Marcas_Itens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estudo_viabilidade_marca_id = table.Column<int>(type: "int", nullable: false),
                    Classe_item_id = table.Column<int>(type: "int", nullable: false),
                    Texto_livre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parecer = table.Column<short>(type: "smallint", nullable: false),
                    Gerada_os = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudo_Viabilidade_Marcas_Itens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estudo_Viabilidade_Marcas_Itens_Classes_Itens_Classe_item_id",
                        column: x => x.Classe_item_id,
                        principalTable: "Classes_Itens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estudo_Viabilidade_Marcas_Itens_Estudo_Viabilidade_Marcas_Estudo_viabilidade_marca_id",
                        column: x => x.Estudo_viabilidade_marca_id,
                        principalTable: "Estudo_Viabilidade_Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Processos_Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Processoid = table.Column<int>(type: "int", nullable: false),
                    Elementonominativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<short>(type: "smallint", nullable: false),
                    Logosituacao = table.Column<short>(type: "smallint", nullable: false),
                    Logomarca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Situacaoespecial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resultados = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conclusao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Situacaoid = table.Column<short>(type: "smallint", nullable: false),
                    Classeid = table.Column<int>(type: "int", nullable: false),
                    Inicioprazoordinario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inicioprazoextraordinario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fimprazoordinario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fimprazoextraordinario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Datavigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos_Marcas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processos_Marcas_Classes_Classeid",
                        column: x => x.Classeid,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Processos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pedidoid = table.Column<int>(type: "int", nullable: false),
                    Processosituacaoid = table.Column<int>(type: "int", nullable: false),
                    Datarenovacao = table.Column<TimeSpan>(type: "time", nullable: false),
                    Servicoid = table.Column<short>(type: "smallint", nullable: false),
                    Tipo = table.Column<short>(type: "smallint", nullable: false),
                    Processofilhoid = table.Column<int>(type: "int", nullable: false),
                    Numeroprocesso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clienteid = table.Column<int>(type: "int", nullable: false),
                    Empresaid = table.Column<int>(type: "int", nullable: false),
                    Datacriacao = table.Column<TimeSpan>(type: "time", nullable: false),
                    Situacaoregistroid = table.Column<int>(type: "int", nullable: false),
                    Data_ultimasituacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processos_Pedidos_Pedidoid",
                        column: x => x.Pedidoid,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processos_Processos_Marcas_Processofilhoid",
                        column: x => x.Processofilhoid,
                        principalTable: "Processos_Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processos_Processos_Situacoes_Processosituacaoid",
                        column: x => x.Processosituacaoid,
                        principalTable: "Processos_Situacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processos_Servicos_Servicoid",
                        column: x => x.Servicoid,
                        principalTable: "Servicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Processos_Marcas_Classes_Itens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Processomarcaid = table.Column<int>(type: "int", nullable: false),
                    Classeitemid = table.Column<int>(type: "int", nullable: false),
                    Textolivre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos_Marcas_Classes_Itens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processos_Marcas_Classes_Itens_Classes_Itens_Classeitemid",
                        column: x => x.Classeitemid,
                        principalTable: "Classes_Itens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Processos_Marcas_Classes_Itens_Processos_Marcas_Processomarcaid",
                        column: x => x.Processomarcaid,
                        principalTable: "Processos_Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Processos_Servicos_Adicionais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Processomarcaid = table.Column<int>(type: "int", nullable: false),
                    Servicoid = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos_Servicos_Adicionais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processos_Servicos_Adicionais_Processos_Marcas_Processomarcaid",
                        column: x => x.Processomarcaid,
                        principalTable: "Processos_Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processos_Servicos_Adicionais_Servicos_Servicoid",
                        column: x => x.Servicoid,
                        principalTable: "Servicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Despachos_Detalhes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Despachoid = table.Column<int>(type: "int", nullable: false),
                    Processoid = table.Column<int>(type: "int", nullable: false),
                    Tipodespachoid = table.Column<int>(type: "int", nullable: false),
                    Texto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datainclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inicioprazoordinario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fimprazoordinario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inicioprazoextraordinario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fimprazoextraordinario = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despachos_Detalhes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Despachos_Detalhes_Despachos_Despachoid",
                        column: x => x.Despachoid,
                        principalTable: "Despachos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Despachos_Detalhes_Processos_Processoid",
                        column: x => x.Processoid,
                        principalTable: "Processos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Despachos_Detalhes_TiposDespachos_Tipodespachoid",
                        column: x => x.Tipodespachoid,
                        principalTable: "TiposDespachos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Processos_Peticoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Processoid = table.Column<int>(type: "int", nullable: false),
                    Tipodespachoid = table.Column<int>(type: "int", nullable: false),
                    Pedidoid = table.Column<int>(type: "int", nullable: false),
                    Numeroprotocolo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dataprotocolo = table.Column<TimeSpan>(type: "time", nullable: false),
                    Texto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prazoordinario = table.Column<int>(type: "int", nullable: false),
                    Prazoextraordinario = table.Column<int>(type: "int", nullable: false),
                    Custo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Situacaopeticaoid = table.Column<short>(type: "smallint", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Nossonumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datacriacao = table.Column<TimeSpan>(type: "time", nullable: false),
                    Numeroprocesso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dataprazoordinario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dataprazoextraordinario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Despachodetalheid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos_Peticoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processos_Peticoes_Pedidos_Pedidoid",
                        column: x => x.Pedidoid,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processos_Peticoes_Processos_Processoid",
                        column: x => x.Processoid,
                        principalTable: "Processos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processos_Peticoes_TiposDespachos_Tipodespachoid",
                        column: x => x.Tipodespachoid,
                        principalTable: "TiposDespachos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Processos_Movimentacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Processopeticaoid = table.Column<int>(type: "int", nullable: false),
                    Datahora = table.Column<TimeSpan>(type: "time", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<short>(type: "smallint", nullable: false),
                    Tarefaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos_Movimentacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processos_Movimentacoes_Processos_Peticoes_Processopeticaoid",
                        column: x => x.Processopeticaoid,
                        principalTable: "Processos_Peticoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Processos_Movimentacoes_Tarefas_Tarefaid",
                        column: x => x.Tarefaid,
                        principalTable: "Tarefas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_Estadoid",
                table: "Cidades",
                column: "Estadoid");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Itens_ClassesId",
                table: "Classes_Itens",
                column: "ClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesEmpresas_Cargoid",
                table: "ClientesEmpresas",
                column: "Cargoid");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesEmpresas_Clienteid",
                table: "ClientesEmpresas",
                column: "Clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesEmpresas_Empresaid",
                table: "ClientesEmpresas",
                column: "Empresaid");

            migrationBuilder.CreateIndex(
                name: "IX_Correspondentes_Pessoa_id",
                table: "Correspondentes",
                column: "Pessoa_id");

            migrationBuilder.CreateIndex(
                name: "IX_Despachos_Detalhes_Despachoid",
                table: "Despachos_Detalhes",
                column: "Despachoid");

            migrationBuilder.CreateIndex(
                name: "IX_Despachos_Detalhes_Processoid",
                table: "Despachos_Detalhes",
                column: "Processoid");

            migrationBuilder.CreateIndex(
                name: "IX_Despachos_Detalhes_Tipodespachoid",
                table: "Despachos_Detalhes",
                column: "Tipodespachoid");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_Classes_Classeitemid",
                table: "Empresas_Classes",
                column: "Classeitemid");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_Classes_Empresaid",
                table: "Empresas_Classes",
                column: "Empresaid");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_Cnaes_Cnaeid",
                table: "Empresas_Cnaes",
                column: "Cnaeid");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_Cnaes_Empresaid",
                table: "Empresas_Cnaes",
                column: "Empresaid");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_Paisid",
                table: "Estados",
                column: "Paisid");

            migrationBuilder.CreateIndex(
                name: "IX_Estudo_Viabilidade_Clienteid",
                table: "Estudo_Viabilidade",
                column: "Clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Estudo_Viabilidade_Empresaid",
                table: "Estudo_Viabilidade",
                column: "Empresaid");

            migrationBuilder.CreateIndex(
                name: "IX_Estudo_Viabilidade_Ordem_servico_id",
                table: "Estudo_Viabilidade",
                column: "Ordem_servico_id");

            migrationBuilder.CreateIndex(
                name: "IX_Estudo_Viabilidade_Status_proposta_id",
                table: "Estudo_Viabilidade",
                column: "Status_proposta_id");

            migrationBuilder.CreateIndex(
                name: "IX_Estudo_Viabilidade_Usuario_criador_id",
                table: "Estudo_Viabilidade",
                column: "Usuario_criador_id");

            migrationBuilder.CreateIndex(
                name: "IX_Estudo_Viabilidade_Usuario_responsavel_id",
                table: "Estudo_Viabilidade",
                column: "Usuario_responsavel_id");

            migrationBuilder.CreateIndex(
                name: "IX_Estudo_Viabilidade_Marcas_Estudo_viabilidade_id",
                table: "Estudo_Viabilidade_Marcas",
                column: "Estudo_viabilidade_id");

            migrationBuilder.CreateIndex(
                name: "IX_Estudo_Viabilidade_Marcas_Itens_Classe_item_id",
                table: "Estudo_Viabilidade_Marcas_Itens",
                column: "Classe_item_id");

            migrationBuilder.CreateIndex(
                name: "IX_Estudo_Viabilidade_Marcas_Itens_Estudo_viabilidade_marca_id",
                table: "Estudo_Viabilidade_Marcas_Itens",
                column: "Estudo_viabilidade_marca_id");

            migrationBuilder.CreateIndex(
                name: "IX_Instituicoes_Pessoa_id",
                table: "Instituicoes",
                column: "Pessoa_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ordem_Servico_Colaboradores_Ordem_servico_id",
                table: "Ordem_Servico_Colaboradores",
                column: "Ordem_servico_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ordem_Servico_Colaboradores_Pessoa_id",
                table: "Ordem_Servico_Colaboradores",
                column: "Pessoa_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ordem_Servico_Comissoes_Ordem_servico_id",
                table: "Ordem_Servico_Comissoes",
                column: "Ordem_servico_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ordem_Servico_Comissoes_Pessoa_id",
                table: "Ordem_Servico_Comissoes",
                column: "Pessoa_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_Patentes_Ordemservicoid",
                table: "OrdemServico_Patentes",
                column: "Ordemservicoid");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_Regras_Despachoid",
                table: "OrdemServico_Regras",
                column: "Despachoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_Comissao_Pessoa_id",
                table: "Pessoa_Comissao",
                column: "Pessoa_id");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_Comissao_Tipo_despacho_id",
                table: "Pessoa_Comissao",
                column: "Tipo_despacho_id");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Pedidoid",
                table: "Processos",
                column: "Pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Processofilhoid",
                table: "Processos",
                column: "Processofilhoid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Processosituacaoid",
                table: "Processos",
                column: "Processosituacaoid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Servicoid",
                table: "Processos",
                column: "Servicoid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Marcas_Classeid",
                table: "Processos_Marcas",
                column: "Classeid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Marcas_Processoid",
                table: "Processos_Marcas",
                column: "Processoid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Marcas_Classes_Itens_Classeitemid",
                table: "Processos_Marcas_Classes_Itens",
                column: "Classeitemid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Marcas_Classes_Itens_Processomarcaid",
                table: "Processos_Marcas_Classes_Itens",
                column: "Processomarcaid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Movimentacoes_Processopeticaoid",
                table: "Processos_Movimentacoes",
                column: "Processopeticaoid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Movimentacoes_Tarefaid",
                table: "Processos_Movimentacoes",
                column: "Tarefaid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Peticoes_Pedidoid",
                table: "Processos_Peticoes",
                column: "Pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Peticoes_Processoid",
                table: "Processos_Peticoes",
                column: "Processoid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Peticoes_Tipodespachoid",
                table: "Processos_Peticoes",
                column: "Tipodespachoid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Servicos_Adicionais_Processomarcaid",
                table: "Processos_Servicos_Adicionais",
                column: "Processomarcaid");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Servicos_Adicionais_Servicoid",
                table: "Processos_Servicos_Adicionais",
                column: "Servicoid");

            migrationBuilder.CreateIndex(
                name: "IX_SituacoesRegistro_Automatizacoes_Situacaoregistroid",
                table: "SituacoesRegistro_Automatizacoes",
                column: "Situacaoregistroid");

            migrationBuilder.CreateIndex(
                name: "IX_SituacoesRegistro_Automatizacoes_Tipodespachoid",
                table: "SituacoesRegistro_Automatizacoes",
                column: "Tipodespachoid");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_Despachoid",
                table: "Tarefas",
                column: "Despachoid");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_OrdemServicoId",
                table: "Tarefas",
                column: "OrdemServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_Servicoid",
                table: "Tarefas",
                column: "Servicoid");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_Tipotarefaid",
                table: "Tarefas",
                column: "Tipotarefaid");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_Usuariocriadorid",
                table: "Tarefas",
                column: "Usuariocriadorid");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_Usuarioid",
                table: "Tarefas",
                column: "Usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_Escritorio_Usuarioresponsavelid",
                table: "Tarefas_Escritorio",
                column: "Usuarioresponsavelid");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_Responsaveis_Tarefaid",
                table: "Tarefas_Responsaveis",
                column: "Tarefaid");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_Responsaveis_Usuarioid",
                table: "Tarefas_Responsaveis",
                column: "Usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Pessoa_id",
                table: "Usuario",
                column: "Pessoa_id");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_Pessoa_id",
                table: "Vendedores",
                column: "Pessoa_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Processos_Marcas_Processos_Processoid",
                table: "Processos_Marcas",
                column: "Processoid",
                principalTable: "Processos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processos_Marcas_Classes_Classeid",
                table: "Processos_Marcas");

            migrationBuilder.DropForeignKey(
                name: "FK_Processos_Marcas_Processos_Processoid",
                table: "Processos_Marcas");

            migrationBuilder.DropTable(
                name: "Anexos");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "ClientesEmpresas");

            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Contas_Parcelas");

            migrationBuilder.DropTable(
                name: "Convenios");

            migrationBuilder.DropTable(
                name: "Correspondentes");

            migrationBuilder.DropTable(
                name: "CustosIndividuais");

            migrationBuilder.DropTable(
                name: "Despachos_Detalhes");

            migrationBuilder.DropTable(
                name: "Empresas_Classes");

            migrationBuilder.DropTable(
                name: "Empresas_Cnaes");

            migrationBuilder.DropTable(
                name: "Estudo_Viabilidade_Marcas_Itens");

            migrationBuilder.DropTable(
                name: "FormasPagamento");

            migrationBuilder.DropTable(
                name: "GruposPermissoes");

            migrationBuilder.DropTable(
                name: "GruposPermissoesDetalhes");

            migrationBuilder.DropTable(
                name: "Instituicoes");

            migrationBuilder.DropTable(
                name: "Log_OrdemServico");

            migrationBuilder.DropTable(
                name: "LogErros");

            migrationBuilder.DropTable(
                name: "OpcoesGerais");

            migrationBuilder.DropTable(
                name: "Ordem_Servico_Colaboradores");

            migrationBuilder.DropTable(
                name: "Ordem_Servico_Comissoes");

            migrationBuilder.DropTable(
                name: "OrdemServico_Patentes");

            migrationBuilder.DropTable(
                name: "OrdemServico_Regras");

            migrationBuilder.DropTable(
                name: "Pedidos_Anexos");

            migrationBuilder.DropTable(
                name: "Permissoes");

            migrationBuilder.DropTable(
                name: "Pessoa_Comissao");

            migrationBuilder.DropTable(
                name: "Portes");

            migrationBuilder.DropTable(
                name: "Processos_Log_Situacoes");

            migrationBuilder.DropTable(
                name: "Processos_Marcas_Classes_Itens");

            migrationBuilder.DropTable(
                name: "Processos_Movimentacoes");

            migrationBuilder.DropTable(
                name: "Processos_Servicos_Adicionais");

            migrationBuilder.DropTable(
                name: "Ramos_De_Atividade");

            migrationBuilder.DropTable(
                name: "Regras_Despachos_Fluxos");

            migrationBuilder.DropTable(
                name: "Regras_Despachos_Processos");

            migrationBuilder.DropTable(
                name: "Situacoes_Regras");

            migrationBuilder.DropTable(
                name: "SituacoesRegistro_Automatizacoes");

            migrationBuilder.DropTable(
                name: "Tarefas_Escritorio");

            migrationBuilder.DropTable(
                name: "Tarefas_Responsaveis");

            migrationBuilder.DropTable(
                name: "UsuarioPermissao");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Cnaes");

            migrationBuilder.DropTable(
                name: "Estudo_Viabilidade_Marcas");

            migrationBuilder.DropTable(
                name: "Classes_Itens");

            migrationBuilder.DropTable(
                name: "Processos_Peticoes");

            migrationBuilder.DropTable(
                name: "SituacoesRegistro");

            migrationBuilder.DropTable(
                name: "Tarefas");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Estudo_Viabilidade");

            migrationBuilder.DropTable(
                name: "TiposDespachos");

            migrationBuilder.DropTable(
                name: "Despachos");

            migrationBuilder.DropTable(
                name: "TiposTarefas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Status_Propostas");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Processos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Processos_Marcas");

            migrationBuilder.DropTable(
                name: "Processos_Situacoes");

            migrationBuilder.DropTable(
                name: "Servicos");
        }
    }
}
