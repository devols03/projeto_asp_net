using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório!")]
        [MinLength(2, ErrorMessage = "O Valor máximo é de {0} caracteres!")]
        [MaxLength(150, ErrorMessage = "O Valor máximo é de {0} caracteres!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "O Sobrenome é obrigatório!")]
        [MinLength(2, ErrorMessage = "O Valor máximo é de {0} caracteres!")]
        [MaxLength(150, ErrorMessage = "O Valor máximo é de {0} caracteres!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!")]
        [MaxLength(100, ErrorMessage = "O Valor máximo é de {0} caracteres!")]
        [EmailAddress(ErrorMessage = "Preencha com um e-mail válido!")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateRegister { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }

    }
}
