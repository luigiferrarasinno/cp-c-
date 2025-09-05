using Microsoft.EntityFrameworkCore;
using ProjetoRM98047.Models;

namespace ProjetoRM98047.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<RM98047_Fornecedor> RM98047_Fornecedores { get; set; }
        public DbSet<RM98047_Produto> RM98047_Produtos { get; set; }
        public DbSet<RM98047_Pedido> RM98047_Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("Data Source=oracle.fiap.com.br:1521/ORCL;User Id=RM98047;Password=201104;");
        }
    }
}
