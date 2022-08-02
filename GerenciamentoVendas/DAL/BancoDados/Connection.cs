using System.Data.Common;

namespace GerenciamentoVendas.DAL.BancoDados
{
    public class Connection
    {
        public static DbTransaction Transaction { get; set; }
        public static DbCommand DbCommand { get; set; }
    }
}
