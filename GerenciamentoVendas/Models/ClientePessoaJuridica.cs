
using System;

namespace GerenciamentoVendas.Models
{
    public class ClientePessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public double ValorMonetario { get; set; }
        public string RazaoSocial { get; set; }
        public string Atividades { get; set; }
        public int CodigoIbge { get; set; }
        public Usuario Usuario { get; set; }

        public ClientePessoaJuridica()
        {
        }

        public ClientePessoaJuridica(int id, string nome, string cnpj, double valorMonetario, string razaoSocial, string atividades, Usuario usuario)
            : base(id, nome)
        {
            Cnpj = cnpj;
            ValorMonetario = valorMonetario;
            RazaoSocial = razaoSocial;
            Atividades = atividades;
            Usuario = usuario;
        }

        public void LimparCaractersCnpj()
        {
            this.Cnpj = Cnpj.Replace(".", "").Replace("/", "").Replace("-", "");
        }
    }
}
