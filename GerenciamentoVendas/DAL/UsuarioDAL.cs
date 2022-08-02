using System;
using System.Data;
using System.Text;
using GerenciamentoVendas.DAL.BancoDados;

namespace GerenciamentoVendas.DAL
{
    public class UsuarioDAL
    {
        public static bool GetUsuarios()
        {

            try
            {
                
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT * FROM bd_gerenciadorvendas.usuarios;");

                Command cmd = new Command();
                cmd.CommandText = sql.ToString();

                DataTable retorno = cmd.GetData();                

                if (retorno.Rows.Count > 0)
                {
                    cmd.CommandText = sql.ToString();

                    //retorno = cmd.Execute();

                    if (retorno.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }
    }
}
