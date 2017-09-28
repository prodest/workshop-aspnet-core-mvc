using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.ViewModels
{
    public class RespostaConvidadoViewModel
    {
        [Required(ErrorMessage = "Favor informar seu nome.")]
        [MinLength(5, ErrorMessage = "Seu nome deve conter pelo menos 5 caracteres.")]
        [MaxLength(50, ErrorMessage = "Seu nome deve conter no máximo 50 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu e-mail.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Favor informar seu telefone.")]
        [MinLength(10, ErrorMessage = "O telefone deve conter no mínimo 10 dígitos")]
        [MaxLength(11, ErrorMessage = "O telefone deve conter no máximo 11 dígitos")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Informe um telefone válido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Favor escolher uma opção.")]
        public bool? Presenca { get; set; }
        
    }
}
