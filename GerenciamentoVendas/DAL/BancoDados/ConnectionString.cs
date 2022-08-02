namespace GerenciamentoVendas.DAL.BancoDados
{
    public class ConnectionString
    {
        public string ConnString { get; set; }
        public string ProviderName { get; set; }

        public ConnectionString(string connStringName)
        {
            this.ConnString = "Server=localhost;Database=bd_gerenciadorvendas;Uid=root;Pwd=masterkey;SslMode=none;Pooling=false;";
            this.ProviderName = "MySql.Data.MySqlClient";
        }
    }
}
