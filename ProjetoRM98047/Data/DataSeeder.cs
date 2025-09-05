using ProjetoRM98047.Data;
using ProjetoRM98047.Models;

namespace ProjetoRM98047.Data
{
    public static class DataSeeder
    {
        public static void SeedData(AppDbContext context)
        {
            // Limpar dados existentes
            context.RM98047_Fornecedores.RemoveRange(context.RM98047_Fornecedores);
            context.RM98047_Produtos.RemoveRange(context.RM98047_Produtos);
            context.RM98047_Pedidos.RemoveRange(context.RM98047_Pedidos);
            context.SaveChanges();

            // Inserir 10 fornecedores
            var fornecedores = new List<RM98047_Fornecedor>
            {
                new RM98047_Fornecedor { nrCEP = "01310-100", dsEndereco = "Av. Paulista, 1000", Estado = "SP", Cidade = "São Paulo" },
                new RM98047_Fornecedor { nrCEP = "20040-020", dsEndereco = "Rua da Carioca, 50", Estado = "RJ", Cidade = "Rio de Janeiro" },
                new RM98047_Fornecedor { nrCEP = "30112-000", dsEndereco = "Av. Afonso Pena, 1500", Estado = "MG", Cidade = "Belo Horizonte" },
                new RM98047_Fornecedor { nrCEP = "40070-110", dsEndereco = "Rua Chile, 300", Estado = "BA", Cidade = "Salvador" },
                new RM98047_Fornecedor { nrCEP = "80020-100", dsEndereco = "Rua XV de Novembro, 800", Estado = "PR", Cidade = "Curitiba" },
                new RM98047_Fornecedor { nrCEP = "90010-150", dsEndereco = "Rua dos Andradas, 1200", Estado = "RS", Cidade = "Porto Alegre" },
                new RM98047_Fornecedor { nrCEP = "60160-230", dsEndereco = "Av. Dom Luís, 500", Estado = "CE", Cidade = "Fortaleza" },
                new RM98047_Fornecedor { nrCEP = "50030-230", dsEndereco = "Rua do Bom Jesus, 200", Estado = "PE", Cidade = "Recife" },
                new RM98047_Fornecedor { nrCEP = "70040-010", dsEndereco = "SBS Quadra 2, Bloco A", Estado = "DF", Cidade = "Brasília" },
                new RM98047_Fornecedor { nrCEP = "29010-000", dsEndereco = "Av. Jerônimo Monteiro, 100", Estado = "ES", Cidade = "Vitória" }
            };

            // Inserir 10 produtos
            var produtos = new List<RM98047_Produto>
            {
                new RM98047_Produto { nmProduto = "Notebook Dell Inspiron", preco = 2500.00m },
                new RM98047_Produto { nmProduto = "Mouse Logitech MX Master", preco = 350.00m },
                new RM98047_Produto { nmProduto = "Teclado Mecânico Corsair", preco = 450.00m },
                new RM98047_Produto { nmProduto = "Monitor LG 24 polegadas", preco = 800.00m },
                new RM98047_Produto { nmProduto = "Webcam Logitech C920", preco = 400.00m },
                new RM98047_Produto { nmProduto = "Headset HyperX Cloud", preco = 300.00m },
                new RM98047_Produto { nmProduto = "SSD Samsung 1TB", preco = 600.00m },
                new RM98047_Produto { nmProduto = "Placa de Vídeo RTX 3060", preco = 2200.00m },
                new RM98047_Produto { nmProduto = "Fonte Corsair 650W", preco = 500.00m },
                new RM98047_Produto { nmProduto = "Gabinete Gamer RGB", preco = 350.00m }
            };

            // Inserir 10 pedidos
            var pedidos = new List<RM98047_Pedido>
            {
                new RM98047_Pedido { dataPedido = new DateTime(2024, 1, 15), valorTotal = 1500.00m },
                new RM98047_Pedido { dataPedido = new DateTime(2024, 2, 20), valorTotal = 2800.00m },
                new RM98047_Pedido { dataPedido = new DateTime(2024, 3, 10), valorTotal = 950.00m },
                new RM98047_Pedido { dataPedido = new DateTime(2024, 4, 5), valorTotal = 3200.00m },
                new RM98047_Pedido { dataPedido = new DateTime(2024, 5, 12), valorTotal = 750.00m },
                new RM98047_Pedido { dataPedido = new DateTime(2024, 6, 18), valorTotal = 4100.00m },
                new RM98047_Pedido { dataPedido = new DateTime(2024, 7, 22), valorTotal = 1800.00m },
                new RM98047_Pedido { dataPedido = new DateTime(2024, 8, 8), valorTotal = 2650.00m },
                new RM98047_Pedido { dataPedido = new DateTime(2024, 9, 14), valorTotal = 890.00m },
                new RM98047_Pedido { dataPedido = new DateTime(2024, 10, 30), valorTotal = 5500.00m }
            };

            // Adicionar ao contexto
            context.RM98047_Fornecedores.AddRange(fornecedores);
            context.RM98047_Produtos.AddRange(produtos);
            context.RM98047_Pedidos.AddRange(pedidos);

            // Salvar alterações
            context.SaveChanges();

            Console.WriteLine("Dados inseridos com sucesso!");
            Console.WriteLine($"- {fornecedores.Count} fornecedores inseridos");
            Console.WriteLine($"- {produtos.Count} produtos inseridos");
            Console.WriteLine($"- {pedidos.Count} pedidos inseridos");
        }
    }
}
