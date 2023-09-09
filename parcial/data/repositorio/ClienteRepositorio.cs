using modelo;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace data.repositorio
{
    public class ClienteRepositorio : IclienteRepositorio
    {
        public readonly mysqlconfig _connection;
        public ClienteRepositorio(mysqlconfig connection)
        {
            _connection = connection;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connection._connectionString);
        }
        public async Task<bool> deleteCliente(int id)
        {
            var db = dbConnection();
            var sql = @"delete from clientes where idclientes=@Id";
            var result = await db.ExecuteAsync(sql, new { id });
            return result > 0;
        }

        public Task<Cliente> getClienteById(int id)
        {
            var db = dbConnection();
            var consulta = @"select * from clientes where idclientes=@Id";
            return db.QueryFirstOrDefaultAsync<Cliente>(consulta, new { Id = id });
        }

        public  Task<IEnumerable<Cliente>> getClientes()
        {
            var db = dbConnection();
            var consulta = @"select * from clientes ";
            return db.QueryAsync<Cliente>(consulta);
        }

        public async Task<bool> insertCliente(Cliente cliente)
        {
            var db = dbConnection();
            var sql = @"insert into clientes(nombre,cc,edad,correo,celular) values(@nombre,@cc,@edad,@correo,@celular)";
            var result = await db.ExecuteAsync(sql, new { cliente.nombre, cliente.cc, cliente.edad,cliente.correo,cliente.celular });
            return result > 0;
        }

        public async Task<bool> UpdateClientes(Cliente cliente)
        {
            var db = dbConnection();
            var sql = @"update clientes set nombre=@nombre,cc=@cc,edad=@edad,correo=@correo,celular=@celular where idclientes=@Id";
            var result = await db.ExecuteAsync(sql, new { cliente.nombre, cliente.cc, cliente.edad,cliente.correo, cliente.celular });
            return result > 0;
        }
    }
}
