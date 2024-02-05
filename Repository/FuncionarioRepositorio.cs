using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckService.Models;

namespace TruckService.Repository
{
    public class FuncionarioRepositorio : Repositorio<Funcionario>
    {
        private readonly SqlConnection _connection = new();

        public FuncionarioRepositorio(SqlConnection connection) : base(connection)
            => _connection = connection;

        public IEnumerable<Funcionario> ListarNome(string termo)
        {
            string sql = @"SELECT [Id], [Nome], [CpfCnpj], [DataNascimento]
                           FROM [Funcionario]
                           WHERE Nome like @expressao";

            var funcionarios = _connection.Query<Funcionario>(sql, new
            {
                expressao = $"%{termo}%"
            });

            return funcionarios;
        }
    }
}
