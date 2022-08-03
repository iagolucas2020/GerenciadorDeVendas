using GerenciamentoVendas.DAL;
using GerenciamentoVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoVendas.Services
{
    public class ClientePessoaJuridicaServiceDAL
    {
        public static List<ClientePessoaJuridica> GetAllClientePessoaJuridica()
        {
            try
            {
                return ClientePessoaJuridicaDAL.GetAllClientePessoaJuridica();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static ClientePessoaJuridica GetByIdClientePessoaJuridica(int id)
        {
            try
            {
                return ClientePessoaJuridicaDAL.GetByIdClientePessoaJuridica(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public static bool PostClientePessoaJuridica(ClientePessoaJuridica cliente, int idUsuario, string mensagem)
        {
            try
            {
                return ClientePessoaJuridicaDAL.PostClientePessoaJuridica(cliente, idUsuario, mensagem);
            }
            catch (Exception e)
            {
                mensagem = $"Error: {e.Message}";
                return false;
            }
        }
    }
}
