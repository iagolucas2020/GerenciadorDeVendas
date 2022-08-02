using System;
using System.ComponentModel;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoVendas.DAL.BancoDados
{
    public class DbCommandGeneric
    {
        public DbCommand DbCommand { get; set; }
        public Object TableObject { get; set; }
    }
}
