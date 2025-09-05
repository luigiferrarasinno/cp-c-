using System.ComponentModel.DataAnnotations;

namespace ProjetoRM98047.Models
{
    public class RM98047_Produto
    {
        [Key]
        public int idProduto { get; set; }
        
        public string nmProduto { get; set; }
        
        public decimal preco { get; set; }
    }
}
