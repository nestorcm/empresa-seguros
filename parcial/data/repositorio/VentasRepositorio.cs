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
    public class VentasRepositorio : IVentasRepositorio
    {
        public readonly mysqlconfig _connection;
        public VentasRepositorio(mysqlconfig connection)
        {
            _connection = connection;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connection._connectionString);
        }

        public Task<IEnumerable<ventas>> getVentas()
        {
            var db = dbConnection();
            var consulta = @"select * from ventas ";
            return db.QueryAsync<ventas>(consulta);
        }

        public async Task<bool> insertVentas(ventas venta)
        {
            var db = dbConnection();
            var sql = @"insert into ventas(clientes_idclientes,TipoSeguro_idTipoSeguro,Empleado_idEmpleado,fechaInicioSeguro,fechaFinalSeguro,venta) values(@idcliente,@tiposeguro,@idempleado,@fechaInicioSeguro,@fechaFinalSeguro,venta)";
            var result = await db.ExecuteAsync(sql, new { venta.idcliente, venta.tiposeguro, venta.idempleado, venta.fechaInicioSeguro, venta.fechaFinalSeguro, venta.venta });
            return result > 0;
        }

       
    }
}
