using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OP_RPG.Models.Account
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Coloca BOLSONARO... Combina com o merda que vc é!")]
        [Display(Name = "Nickname")]
        [MaxLength(15)]
        public string? Username{ get; set; }        

        [Required(ErrorMessage = "Tá achando que eu sou sua mãe que todo mundo entra direto sem pedir nada... Introduza uma senha (só a senha, não sou sua mãe que introduzem outras coisas).")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Lembrar-Me")]
        public bool LembrarMe { get; set; }        

        [NotMapped]
        public string? Mensagem { get; set; }
    }
}
