using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoVendas.Models
{
    public class ClientePessoaJuridica : Pessoa
    {
        public int Cnpj { get; set; }
        public double ValorMonetario { get; set; }

        public ClientePessoaJuridica()
        {
        }

        public ClientePessoaJuridica(int id, string nome, int cnpj, double valorMonetario)
            : base(id, nome)
        {
            Cnpj = cnpj;
            ValorMonetario = valorMonetario;
        }
    }
}
