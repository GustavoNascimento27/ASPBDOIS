using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System.ComponentModel.DataAnnotations;

namespace Sextoapp.Models
{
    public class Colaborador
    {
        [Display(Name = "Código", Description = "Código")]
        public int id { get; set; }

        [Display(Name = "Nome Completo", Description = "Nome e sobrenome")]
        [Required(ErrorMessage = "O nome completo é obrigatório. ")]
        public string Nome { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O celular é obrigatório ")]
        public string Telefone { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatório ")]
        public string CPF { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "O email é obrigatório ")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A senha é obrigatória")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "a SENHA deve ter entre 6 a 10 caracteres")]
        public string Senha { get; set; }

        [Display(Name = "tipo")]
        [Required(ErrorMessage = "O TIPO É OBRIGATORIO")]
        public string tipo { get; set; }



    }
}
