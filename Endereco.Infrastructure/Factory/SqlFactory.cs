using Microsoft.Data.SqlClient;
using System.Data;

namespace Endereco.Infrastructure.Factory
{
    public class SqlFactory
    {
        public IDbConnection SqlConnection()
        {
            return new SqlConnection("Server=localhost; Database=FROTACORP_ENDERECO; User=sa; Password=@Passw0rd; Trusted_Connection=False; TrustServerCertificate=True;");
        }
    }
}