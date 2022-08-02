using GerenciamentoVendas.DAL;
using GerenciamentoVendas.Models.Enums;
using GerenciamentoVendas.Services;
using System.Collections.Generic;

namespace GerenciamentoVendas.Models
{
    public class Usuario : Pessoa
    {
        public string Email { get; set; }
        public Regioes Regioes { get; set; }

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
        }

        public Usuario(int id, string nome, string email, Regioes regioes)
            : base(id, nome)
        {
            Email = email;
            Regioes = regioes;
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
