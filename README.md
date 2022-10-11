# Introducão
Projeto pessoal iniciado para uma empresa (Sistemarcas) de registro de marcas com estrutura pronta aproveitável para outros projetos.

# Detalhes gerais
Este projeto está sendo escrito todo em inglês (com exceção a escrita de tabelas e campos que já eram em portugues) 
e possui, models, DTOs, enums, controllers, endpoints, CRUDs, DBContext, entity configuration (Fluent API) e 
convenções de codificação. Seu frontend e backend terão release por meio de Azure Pipelines.

Está sendo estruturado com DDD.

# Camadas
A camada de Domínio contém: Models, Interfaces e Enums.
A camada de Infraestrutura contém: DBContext, Repositórios das entidades, entity configuration (Fluent API), Mappings e Migration.
A camada de aplicação está ainda crua contendo somente algumas interfaces iniciais e um básico de CQRS.
A camada de apresentação (API) contém: Controllers, endpoints, CRUDs, DTOs, autenticação Bearer, configurãção de injeção de dependencia e mapeamentos.
Nesta camada é possível comunicar com o repositório por meio das interfaces de dominio e também por meio do contexto.

# Código
As classes, controllers e outros arquivos para esta tarefa foram colocados dentro de pastas DevExternal (para api informada) e Dev (para cadastro local)

Interfaces: para injeção de dependencia. Abstração = Interface.
Classes: classes implementam interfaces, as classes neste projeto são anemicas.

Convenções de codificação: Declaração de variáveis e métodos públicos e privados, 
	parametros, nomes de classes, nomes de entidades no banco de dados, nomes de campos no banco de dados

# CI/CD
Release: por meio de Azure Pipelines - Iniciado

# Outros
LOG: foi configurado log por meio do Serilog para dentro do MongoDB
