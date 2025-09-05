using Microsoft.EntityFrameworkCore;
using ProjetoRM98047.Data;
using ProjetoRM98047.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Projeto RM98047 - Entity Framework Core com Oracle ===");
        
        try
        {
            using (var context = new AppDbContext())
            {
                Console.WriteLine("Conectando ao banco Oracle...");
                
                // Garante que o banco de dados existe
                context.Database.EnsureCreated();
                
                Console.WriteLine("Conexão com Oracle estabelecida com sucesso!");
                Console.WriteLine("Projeto com as entidades:");
                Console.WriteLine("- RM98047_Fornecedor");
                Console.WriteLine("- RM98047_Produto"); 
                Console.WriteLine("- RM98047_Pedido");
                
                // Inserir dados de exemplo
                Console.WriteLine("\nInserindo dados de exemplo...");
                DataSeeder.SeedData(context);
                
                // Exibe informações das tabelassss
                var fornecedorCount = context.RM98047_Fornecedores.Count();
                var produtoCount = context.RM98047_Produtos.Count();
                var pedidoCount = context.RM98047_Pedidos.Count();
                
                Console.WriteLine($"\nQuantidade de registros no banco:");
                Console.WriteLine($"Fornecedores: {fornecedorCount}");
                Console.WriteLine($"Produtos: {produtoCount}");
                Console.WriteLine($"Pedidos: {pedidoCount}");
                
                // Exibir alguns dados
                Console.WriteLine("\n--- Amostra de Fornecedores ---");
                var fornecedores = context.RM98047_Fornecedores.Take(3).ToList();
                foreach(var f in fornecedores)
                {
                    Console.WriteLine($"ID: {f.idFornecedor}, Cidade: {f.Cidade}, Estado: {f.Estado}");
                }
                
                Console.WriteLine("\n--- Amostra de Produtos ---");
                var produtos = context.RM98047_Produtos.Take(3).ToList();
                foreach(var p in produtos)
                {
                    Console.WriteLine($"ID: {p.idProduto}, Nome: {p.nmProduto}, Preço: R$ {p.preco:F2}");
                }
                
                Console.WriteLine("\n--- Amostra de Pedidos ---");
                var pedidos = context.RM98047_Pedidos.Take(3).ToList();
                foreach(var ped in pedidos)
                {
                    Console.WriteLine($"ID: {ped.idPedido}, Data: {ped.dataPedido:dd/MM/yyyy}, Valor: R$ {ped.valorTotal:F2}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
            if (ex.InnerException != null)
            {
                Console.WriteLine($"Erro interno: {ex.InnerException.Message}");
            }
        }
        
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
