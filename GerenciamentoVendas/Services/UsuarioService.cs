using GerenciamentoVendas.DAL;
using GerenciamentoVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoVendas.Services
{
    public class UsuarioService
    {
        public static List<Usuario> GetAllUsuarios()
        {
            try
            {
                return UsuarioDAL.GetAllUsuarios();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static Usuario GetByIdUsuario(int id)
        {
            try
            {
                return UsuarioDAL.GetByIdUsuario(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static bool PostUsuario(Usuario usuario, string mensagem)
        {
            try
            {
                if (!(usuario.VerificarCadastroEmail(usuario)))
                {
                    mensagem = "Já existe este e-mail cadastrado!";
                    return false;
                };
                return UsuarioDAL.PostUsuario(usuario, mensagem);
                
            }
            catch (Exception e)
            {
                mensagem = $"Error: {e.Message}";
                return false;
            }
        }
    }
}
