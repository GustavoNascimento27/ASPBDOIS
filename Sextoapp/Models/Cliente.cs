using System.ComponentModel.DataAnnotations;

namespace Sextoapp.Models
{
    public class Cliente
    {
        [Display(Name = "Código", Description = "Código")]
        public int id { get; set; }
        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome")]
        [Required(ErrorMessage = "O nome completo é obrigatório")]
        public string Nome { get; set; }

        [Display(Name="Nascimento")]
        [Required(ErrorMessage = "A data é obrigatória")]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Deve conter 1 caracter")]
        public string Sexo { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string cpf { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O Celular é obrigatório")]
        public string Celular { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email não é válido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A senha é obrigatória")]
        [StringLength(10, MinimumLength =  6, ErrorMessage = "a SENHA deve ter entre 6 a 10 caracteres")]
        public string Senha { get; set; }

        [Display(Name = "situacão")]
        [Required(ErrorMessage = "A SITUAÇÃO É OBRIGATORIA")]
        public string situacao { get; set; }



    }
}
