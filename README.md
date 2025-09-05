# Projeto RM98047 - Entity Framework Core com Oracle

## Descrição
Este projeto foi desenvolvido em C# utilizando Entity Framework Core (Code First) conectado ao banco de dados Oracle da FIAP. O projeto contém 3 entidades independentes com o prefixo RM98047.

## Estrutura do Projeto

### Entidades
1. **RM98047_Fornecedor**
   - idFornecedor (PK)
   - nrCEP
   - dsEndereco
   - Estado
   - Cidade

2. **RM98047_Produto**
   - idProduto (PK)
   - nmProduto
   - preco

3. **RM98047_Pedido**
   - idPedido (PK)
   - dataPedido
   - valorTotal

## Configuração do Banco de Dados

### Informações de Conexão Oracle
- **Hostname:** oracle.fiap.com.br
- **SID:** ORCL
- **Username:** RM98047
- **Password:** 201104
- **String de Conexão:** `Data Source=oracle.fiap.com.br:1521/ORCL;User Id=RM98047;Password=201104;`

## Tecnologias Utilizadas
- C# (.NET 9.0)
- Entity Framework Core 9.0.8
- Oracle.EntityFrameworkCore 9.23.90
- Oracle.ManagedDataAccess.Core 23.9.0

## Como Executar

### Pré-requisitos
- .NET 9.0 SDK
- Acesso ao banco Oracle da FIAP

### Comandos Executados

1. **Criar o projeto:**
   ```bash
   dotnet new console -n "ProjetoRM98047"
   cd ProjetoRM98047
   ```

2. **Adicionar pacotes NuGet:**
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   dotnet add package Microsoft.EntityFrameworkCore.Tools
   dotnet add package Oracle.EntityFrameworkCore
   ```

3. **Instalar ferramenta EF global:**
   ```bash
   dotnet tool install --global dotnet-ef
   ```

4. **Criar Migration:**
   ```bash
   dotnet ef migrations add Inicial
   ```

5. **Aplicar Migration:**
   ```bash
   dotnet ef database update
   ```

6. **Executar o projeto:**
   ```bash
   dotnet run
   ```

## Estrutura de Arquivos

```
ProjetoRM98047/
├── Data/
│   ├── AppDbContext.cs          # Context do Entity Framework
│   └── DataSeeder.cs            # Classe para inserir dados de exemplo
├── Models/
│   ├── RM98047_Fornecedor.cs    # Entidade Fornecedor
│   ├── RM98047_Produto.cs       # Entidade Produto
│   └── RM98047_Pedido.cs        # Entidade Pedido
├── Migrations/
│   └── [Arquivos de Migration]   # Scripts de migração gerados
├── Program.cs                    # Arquivo principal da aplicação
└── ProjetoRM98047.csproj        # Arquivo de projeto
```

## Dados de Exemplo

O projeto insere automaticamente 10 registros em cada tabela:

### Fornecedores
- 10 fornecedores de diferentes estados brasileiros
- Dados incluem CEP, endereço, estado e cidade

### Produtos
- 10 produtos de tecnologia
- Inclui notebooks, periféricos e componentes
- Preços variando de R$ 300,00 a R$ 2.500,00

### Pedidos
- 10 pedidos com datas de 2024
- Valores totais variando de R$ 750,00 a R$ 5.500,00

## Funcionalidades

- ✅ Conexão com banco Oracle
- ✅ 3 entidades independentes com prefixo RM98047
- ✅ Migrations configuradas
- ✅ 10 registros em cada tabela


## Evidências de Execução

O projeto executa com sucesso e exibe:
- Confirmação de conexão com Oracle
- Contagem de registros inseridos
- Amostra dos dados de cada tabela

## Autor
**Luigi Ferrara Sinno - RM98047**  
Projeto desenvolvido para avaliação de Entity Framework Core

## 📋 Dicas para Verificação - Professor

### Comandos SQL para Verificação no Oracle

Para verificar os dados inseridos nas tabelas, utilize os seguintes comandos no Oracle SQL Developer ou DBeaver:

```sql
-- Verificar todas as tabelas criadas
SELECT table_name FROM user_tables WHERE table_name LIKE 'RM98047%';

-- Consultar todos os dados das tabelas
SELECT * FROM RM98047."RM98047_Fornecedores" ORDER BY "idFornecedor";
SELECT * FROM RM98047."RM98047_Produtos" ORDER BY "idProduto";  
SELECT * FROM RM98047."RM98047_Pedidos" ORDER BY "idPedido";

-- Verificar quantidade de registros
SELECT 'Fornecedores' as Tabela, COUNT(*) as Total FROM RM98047."RM98047_Fornecedores"
UNION ALL
SELECT 'Produtos' as Tabela, COUNT(*) as Total FROM RM98047."RM98047_Produtos"
UNION ALL  
SELECT 'Pedidos' as Tabela, COUNT(*) as Total FROM RM98047."RM98047_Pedidos";
```

### Evidências de Funcionamento

1. **Execução da aplicação:** Execute `dotnet run` no terminal
2. **Verificação do banco:** Use os comandos SQL acima no DBeaver ou Oracle SQL Developer
3. **Migrations aplicadas:** Os arquivos estão na pasta `Migrations/`
4. **Code First confirmado:** O banco é criado automaticamente pelo EF Core

> **Nota:** Utilizei DBeaver como ferramenta de conexão com o Oracle pois eu uso ele no trabalho e ja estou mais acustumado.
