using GerenciamentoVendas.DAL;
using GerenciamentoVendas.Models.Enums;
using GerenciamentoVendas.Services;
using System;
using System.Collections.Generic;

namespace GerenciamentoVendas.Models
{
    public class Usuario : Pessoa
    {
        public string Email { get; set; }
        public Regioes Regioes { get; set; }
        public DateTime DataAtualizacaoRegiao { get; set; }
        public ClientePessoaJuridica ClientePessoaJuridica { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id)
        {
            Usuario usuario = UsuarioDAL.GetByIdUsuario(id);
            this.Id = usuario.Id;
            this.Nome = usuario.Nome;
            this.Email = usuario.Email;
            this.Regioes = usuario.Regioes;
            this.DataAtualizacaoRegiao = usuario.DataAtualizacaoRegiao;
        }

        public Usuario(int id, string nome, string email, DateTime data, Regioes regioes, ClientePessoaJuridica clientePessoaJuridica)
            : base(id, nome)
        {
            Email = email;
            DataAtualizacaoRegiao = data;
            Regioes = regioes;
            ClientePessoaJuridica = clientePessoaJuridica;
        }

        public Usuario(int id, string nome, string email, Regioes regioes, DateTime data)
            : base(id, nome)
        {
            Email = email;
            Regioes = regioes;
            DataAtualizacaoRegiao = data;
        }

        public bool VerificarCadastroEmail(Usuario usuario)
        {
            List<Usuario> list = UsuarioService.GetAllUsuarios();
            if (list.Find(u => u.Email == usuario.Email) != null)
            {
                return false;
            };
            return true;
        }

    }
}
