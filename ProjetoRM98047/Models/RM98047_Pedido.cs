using System.ComponentModel.DataAnnotations;

namespace ProjetoRM98047.Models
{
    public class RM98047_Pedido
    {
        [Key]
        public int idPedido { get; set; }
        
        public DateTime dataPedido { get; set; }
        
        public decimal valorTotal { get; set; }
    }
}
