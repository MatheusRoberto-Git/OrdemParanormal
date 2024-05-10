using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OP_RPG.Models.Account
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Animal, fala a verdade para os teus amigos... Vc vai montar uma ficha muito zika para compensar o fracasso que é vc!")]
        [Display(Name = "Nickname")]
        [MaxLength(15)]
        public string? Username { get; set; }

        [Required(ErrorMessage = "O Dev tbm merece ser esculachado, seu DEV de merda... Ainda não serve pra nada mas se não colocar E-mail não vai funcionar!")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Tá achando que eu sou sua mãe que todo mundo entra direto sem pedir nada... Introduza uma senha (só a senha, não sou sua mãe que introduzem outras coisas).")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }        

        [NotMapped]
        [Compare("Password", ErrorMessage = "Burro, As senhas devem ser INGUAIS... Indiota!")]
        [DataType(DataType.Password)]
        public string? ConfirmarSenha { get; set; }

        [NotMapped]
        public string? Mensagem { get; set; }        
    }
}
