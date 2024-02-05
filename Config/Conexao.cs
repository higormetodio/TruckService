using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckService.Repository;

namespace TruckService.Config
{
    // Classe estática responsável por fornecer a conexão com o banco
    public static class Conexao
    {
        private readonly static SqlConnectionStringBuilder builder = new()
        {
            DataSource = "localhost",
            UserID = "sa",
            Password = "1Q2w3e4R",
            InitialCatalog = "TruckService",
            IntegratedSecurity = false,
            TrustServerCertificate = true,
            Encrypt = false,
            Authentication = SqlAuthenticationMethod.SqlPassword
        };

        public static readonly SqlConnection connection = new(builder.ConnectionString);
    }
}
