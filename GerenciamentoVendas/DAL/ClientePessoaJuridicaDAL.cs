using GerenciamentoVendas.DAL.BancoDados;
using GerenciamentoVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GerenciamentoVendas.DAL
{
    public class ClientePessoaJuridicaDAL
    {
        public static List<ClientePessoaJuridica> GetAllClientePessoaJuridica()
        {
            List<ClientePessoaJuridica> list = new List<ClientePessoaJuridica>();

            try
            {
                StringBuilder sql = new StringBuilder();

                //Query do Banco de Dados
                sql.Append(" SELECT * FROM bd_gerenciadorvendas.cliente_pessoa_juridica; ");

                //Conexão banco
                Command cmd = new Command();
                cmd.CommandText = sql.ToString();
                DataTable retorno = cmd.GetData();

                //Retorno dos dados do banco
                if (retorno.Rows.Count > 0)
                {
                    foreach (DataRow linha in retorno.Rows)
                    {
                        int id = Convert.ToInt32(linha["ID"].ToString());
                        string nome = linha["NOME"].ToString();
                        string cnpj = linha["CNPJ"].ToString();
                        double valor = Convert.ToDouble(linha["VALOR_MONETARIO"].ToString());
                        string razao = linha["RAZAO_SOCIAL"].ToString();
                        string atividades = linha["ATIVIDADES"].ToString();
                        int codigoUsuario = Convert.ToInt32(linha["CODIGO_USUARIO"].ToString());

                        list.Add(new ClientePessoaJuridica(id, nome, cnpj, valor, razao, atividades, new Usuario(codigoUsuario)));
                    }
                }

                return list;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
        public static ClientePessoaJuridica GetByIdClientePessoaJuridica(int id)
        {
            ClientePessoaJuridica cliente = new ClientePessoaJuridica();

            try
            {
                StringBuilder sql = new StringBuilder();

                //Query do Banco de Dados
                sql.Append($" SELECT * FROM bd_gerenciadorvendas.cliente_pessoa_juridica ");
                sql.Append($" WHERE ID = {id};");

                //Conexão banco
                Command cmd = new Command();
                cmd.CommandText = sql.ToString();
                DataTable retorno = cmd.GetData();

                //Retorno dos dados do banco
                if (retorno.Rows.Count > 0)
                {
                    DataRow linha = retorno.Rows[0];
                    cliente.Id = Convert.ToInt32(linha["ID"].ToString());
                    cliente.Nome = linha["NOME"].ToString();
                    cliente.Cnpj = linha["CNPJ"].ToString();
                    cliente.ValorMonetario = Convert.ToDouble(linha["VALOR_MONETARIO"].ToString());
                    cliente.RazaoSocial = linha["RAZAO_SOCIAL"].ToString();
                    cliente.Atividades = linha["ATIVIDADES"].ToString();
                }
                return cliente;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static bool PostClientePessoaJuridica(ClientePessoaJuridica cliente, int idUsuario, string mensagem)
        {
            try
            {
                Command cmd = new Command();
                StringBuilder sql = new StringBuilder();

                sql.AppendLine($" INSERT INTO bd_gerenciadorvendas.cliente_pessoa_juridica (NOME, CNPJ, VALOR_MONETARIO, RAZAO_SOCIAL, ATIVIDADES, CODIGO_USUARIO) ");
                sql.AppendLine($" VALUES ('{cliente.Nome}','{cliente.Cnpj}', '{cliente.ValorMonetario}', '{cliente.RazaoSocial}', '{cliente.Atividades}', '{idUsuario}')");

                cmd.CommandText = sql.ToString();

                int retorno = cmd.Execute();
                if (retorno > 0)
                {
                    mensagem = "Dados Cadastrados com Sucesso";
                    return true;
                }
                else
                {
                    mensagem = "Não foi possível realizar o cadastro";
                    return false;
                }
            }
            catch (Exception e)
            {
                mensagem = $"Error: {e.Message}";
                return false;
            }
        }
    }
}
