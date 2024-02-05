using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace TruckService.Repository
{
    public class Repositorio<T> where T : class
    {
        public readonly SqlConnection _connection;

        public Repositorio(SqlConnection connection)
            => _connection = connection;

        public T Listar(int id)
            => _connection.Get<T>(id);

        public IEnumerable<T> Listar()
            => _connection.GetAll<T>();

        public void Inserir(T modelo)
            => _connection.Insert(modelo);

        public void Atualizar(T modelo)
            => _connection.Update(modelo);

        public void Deletar(T modelo)
            => _connection.Delete(modelo);

    }
}
