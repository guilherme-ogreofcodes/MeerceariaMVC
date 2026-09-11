using System.ComponentModel.DataAnnotations;

namespace MerceariaMVC.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }
        public bool Validar()
        {
            if (Idade <18)
            {
                return false;
            }
            if (string.IsNullOrEmpty(Nome))
            {
                return false;
            }
            if(string.IsNullOrEmpty(Email))
            {
                return false;
            }
            if (!Email.Contains("@"))
            {
                return false;
            }
            return true;  
        }
        public bool PodeComprar()
        {
            if (Ativo == false);
            {
                return false;
            }
            return true;
        }
    }
}
