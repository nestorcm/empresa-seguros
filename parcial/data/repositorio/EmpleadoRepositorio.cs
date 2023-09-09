using Dapper;
using modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repositorio
{
    public class EmpleadoRepositorio : IEmpleadoRepositorio
    {
        public readonly mysqlconfig _connection;
        public EmpleadoRepositorio(mysqlconfig connection)
        {
            _connection = connection;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connection._connectionString);
        }
        public async Task<bool> deleteEmpleado(int id)
        {
            var db = dbConnection();
            var sql = @"delete from empleado where idEmpleado=@Id";
            var result = await db.ExecuteAsync(sql, new { id });
            return result > 0;
        }

        public Task<IEnumerable<empleado>> getEmpleado()
        {
            var db = dbConnection();
            var consulta = @"select * from empleado ";
            return db.QueryAsync<empleado>(consulta);
        }

        public  Task<empleado> getEmpleadoById(int id)
        {
            var db = dbConnection();
            var consulta = @"select * from empleado where idEmpleado=@Id";
            return db.QueryFirstOrDefaultAsync<empleado>(consulta, new { Id = id });
        }

        public async Task<bool> insertEmpleado(empleado empleado)
        {
            var db = dbConnection();
            var sql = @"insert into empleado(nombre,cc,edad,celular) values(@nombre,@cc,@edad,@celular)";
            var result = await db.ExecuteAsync(sql, new { empleado.nombre, empleado.cc, empleado.edad,  empleado.celular });
            return result > 0;
        }

        public async Task<bool> UpdateEmpleado(empleado empleado)
        {
            var db = dbConnection();
            var sql = @"update clientes set nombre=@nombre,cc=@cc,edad=@edad,celular=@celular where idclientes=@Id";
            var result = await db.ExecuteAsync(sql, new { empleado.nombre, empleado.cc, empleado.edad, empleado.celular });
            return result > 0;
        }
    }
}
