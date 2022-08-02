
using GerenciamentoVendas.Models.Enums;

namespace GerenciamentoVendas.Models
{
    public class Usuario : Pessoa
    {
        public string Email { get; set; }
        public Regioes Regioes { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id, string nome, string email, Regioes regioes)
            : base(id, nome)
        {
            Email = email;
            Regioes = regioes;
        }
    }
}
