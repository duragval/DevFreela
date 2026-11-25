# DevFreela API

API REST desenvolvida com C# e ASP.NET Core, como parte de uma mentoria .NET voltada ao aprendizado e à construção de uma estrutura de API REST.

O projeto tem como objetivo aplicar, na prática, conceitos e boas práticas do desenvolvimento de APIs utilizando o ecossistema .NET.

Projeto de estudo: este repositório faz parte de uma mentoria .NET e está sendo desenvolvido de forma incremental. Por esse motivo, algumas funcionalidades ainda não estão implementadas ou possuem implementações provisórias. A estrutura atual representa etapas do processo de aprendizado e evolução do projeto, e não uma aplicação finalizada.

## Tecnologias utilizadas

- C#
- ASP.NET Core Web API
- .NET 10
- OpenAPI
- Scalar

## Funcionalidades

Atualmente, o projeto possui endpoints organizados para:

- Consulta de projetos;
- Criação de projetos;
- Atualização e exclusão de projetos;
- Início e conclusão de projetos;
- Comentários em projetos;
- Cadastro de usuários;
- Envio de imagem de perfil;
- Configuração de limites para o custo de projetos;
- Tratamento centralizado de exceções.

> **Nota:** Algumas funcionalidades ainda estão em desenvolvimento. Os endpoints atuais servem como estrutura inicial e podem não realizar operações persistentes.

## Estrutura do projeto

```text
DevFreelaAPI/
├── Controllers/
│   ├── ProjectsController.cs
│   ├── SkillsController.cs
│   └── UsersController.cs
├── ExceptionHandler/
│   └── ApiExceptionHandler.cs
├── Models/
│   ├── CreatePjtCommentInputModel.cs
│   ├── CreatePjtInputModel.cs
│   ├── FreelanceCostConfig.cs
│   └── UpdatePjtInputModel.cs
├── Properties/
├── Services/
│   └── IConfigService.cs
├── appsettings.example.json
├── Program.cs
└── DevFreelaAPI.csproj
```

### Organização

- **Controllers:** responsáveis por receber e responder às requisições HTTP.
- **Models:** representam os dados recebidos pelos endpoints e as configurações da aplicação.
- **Services:** contêm abstrações de serviços utilizados pela aplicação.
- **ExceptionHandler:** responsável pelo tratamento centralizado de exceções.
- **Program.cs:** configura os serviços e o pipeline de execução da API.

## Endpoints

### Projetos

| Método | Endpoint | Descrição |
|---|---|---|
| GET | `/api/projects` | Consulta projetos |
| GET | `/api/projects/{id}` | Consulta projeto por ID |
| POST | `/api/projects` | Cria um projeto |
| PUT | `/api/projects/{id}` | Atualiza um projeto |
| DELETE | `/api/projects/{id}` | Exclui um projeto |
| PUT | `/api/projects/{id}/start` | Inicia um projeto |
| PUT | `/api/projects/{id}/complete` | Conclui um projeto |
| POST | `/api/projects/{id}/comments` | Adiciona comentário |

### Usuários

| Método | Endpoint | Descrição |
|---|---|---|
| POST | `/api/users` | Cadastro de usuário |
| PUT | `/api/users/{id}/profile-pic` | Envio de imagem de perfil |

### Habilidades

| Método | Endpoint | Descrição |
|---|---|---|
| — | `/api/skills` | Controller reservado para funcionalidades de habilidades |

## Configuração

A aplicação utiliza o arquivo `appsettings.json` para armazenar configurações.

O projeto disponibiliza o arquivo `appsettings.example.json` como referência para configuração do ambiente.

Exemplo:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "FreelanceCostConfig": {
    "Min": 1000,
    "Max": 999999
  }
}
```

A seção `FreelanceCostConfig` define os limites mínimo e máximo permitidos para o custo de um projeto.

Esses valores são vinculados à classe `FreelanceCostConfig` por meio do sistema de configuração do ASP.NET Core.

## Como executar o projeto

### Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Git

### 1. Clone o repositório

```bash
git clone https://github.com/duragval/DevFreela.git
```

### 2. Acesse a pasta do projeto

```bash
cd DevFreela/DevFreelaAPI
```

### 3. Restaure as dependências

```bash
dotnet restore
```

### 4. Execute a aplicação

```bash
dotnet run
```

A aplicação será iniciada conforme as configurações do ambiente definidas em `Properties/launchSettings.json`.

## Documentação da API

Durante o desenvolvimento, a aplicação disponibiliza documentação OpenAPI e uma interface interativa Scalar.

Com a aplicação em execução no ambiente de desenvolvimento, acesse:

- OpenAPI: `/openapi/v1.json`
- Scalar: `/scalar`

As rotas podem variar conforme a configuração de execução da aplicação.

## Autor

**Varlei Oliveira**

- GitHub: [@duragval](https://github.com/duragval)
- Repositório: [DevFreela](https://github.com/duragval/DevFreela)

