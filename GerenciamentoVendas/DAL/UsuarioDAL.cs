﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using GerenciamentoVendas.DAL.BancoDados;
using GerenciamentoVendas.Models;
using GerenciamentoVendas.Models.Enums;

namespace GerenciamentoVendas.DAL
{
    public class UsuarioDAL
    {
        public static List<Usuario> GetAllUsuarios()
        {
            List<Usuario> list = new List<Usuario>();

            try
            {
                StringBuilder sql = new StringBuilder();

                //Query do Banco de Dados
                sql.Append(" SELECT * FROM bd_gerenciadorvendas.usuarios; ");

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
                        string email = linha["EMAIL"].ToString();
                        string regiao = linha["REGIAO"].ToString();

                        list.Add(new Usuario(id, nome, email, Enum.Parse<Regioes>(regiao)));
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

        public static Usuario GetByIdUsuario(int id)
        {
            Usuario usuario = new Usuario();

            try
            {
                StringBuilder sql = new StringBuilder();

                //Query do Banco de Dados
                sql.Append($" SELECT * FROM bd_gerenciadorvendas.usuarios ");
                sql.Append($" WHERE ID = {id};");

                //Conexão banco
                Command cmd = new Command();
                cmd.CommandText = sql.ToString();
                DataTable retorno = cmd.GetData();

                //Retorno dos dados do banco
                if (retorno.Rows.Count > 0)
                {
                    DataRow linha = retorno.Rows[0];
                    usuario.Id = Convert.ToInt32(linha["ID"].ToString());
                    usuario.Nome = linha["NOME"].ToString();
                    usuario.Email = linha["EMAIL"].ToString();
                    usuario.Regioes = Enum.Parse<Regioes>(linha["REGIAO"].ToString());
                }
                return usuario;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool PostUsuario(Usuario usuario, string mensagem)
        {
            try
            {
                Command cmd = new Command();
                StringBuilder sql = new StringBuilder();

                sql.AppendLine($" INSERT INTO bd_gerenciadorvendas.usuarios (NOME, EMAIL, REGIAO) ");
                sql.AppendLine($" VALUES ('{usuario.Nome}', '{usuario.Email}', '{Enum.Parse<Regioes>(usuario.Regioes.ToString())}')");

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
