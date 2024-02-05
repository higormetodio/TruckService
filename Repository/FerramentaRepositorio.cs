using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckService.Models;

namespace TruckService.Repository
{
    public class FerramentaRepositorio : Repositorio<Ferramenta>
    {
        private readonly SqlConnection _connection = new();
        public FerramentaRepositorio(SqlConnection connection) : base(connection)
        {
            _connection = connection;
        }

        public List<Ferramenta> ListarFerramentas(int id)
        {
            string query = @"SELECT * 
                             FROM [Ferramenta] 
                             WHERE [FuncionarioID] = @Id OR [FuncionarioId] IS NULL";

            var ferramentas = _connection.Query<Ferramenta>(query, new { Id = id });

            return ferramentas.ToList();
        }

    }
}
