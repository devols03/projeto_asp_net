using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório!")]
        [MinLength(2, ErrorMessage = "O Valor máximo é de {0} caracteres!")]
        [MaxLength(250, ErrorMessage = "O Valor máximo é de {0} caracteres!")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999")]
        [Required(ErrorMessage = "O Valor é obrigatório!")]
        public decimal Price { get; set; }

        [DisplayName("Disponível?")]
        public bool Available { get; set; }

        public int ClientId { get; set; }

        public virtual ClientViewModel Client { get; set; }
    }
}
