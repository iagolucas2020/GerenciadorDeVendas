using System;
using GerenciamentoVendas.Services;

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

        public ClientePessoaJuridica(int id)
        {
            ClientePessoaJuridica cliente = ClientePessoaJuridicaService.GetByIdClientePessoaJuridica(id);
            this.Id = cliente.Id;
            this.Nome = cliente.Nome;
            this.Cnpj = cliente.Cnpj;
            this.ValorMonetario = cliente.ValorMonetario;
            this.RazaoSocial = cliente.RazaoSocial;
            this.Atividades = cliente.Atividades;
        }

        public ClientePessoaJuridica(string cnpj, string razaoSocial, double valorMonetario, string atividades)
        {
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            ValorMonetario = valorMonetario;
            Atividades = atividades;
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
