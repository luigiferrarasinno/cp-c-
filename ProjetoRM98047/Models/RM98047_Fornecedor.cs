using System.ComponentModel.DataAnnotations;

namespace ProjetoRM98047.Models
{
    public class RM98047_Fornecedor
    {
        [Key]
        public int idFornecedor { get; set; }
        
        public string nrCEP { get; set; }
        
        public string dsEndereco { get; set; }
        
        public string Estado { get; set; }
        
        public string Cidade { get; set; }
    }
}
