using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repositorio
{
    public interface IclienteRepositorio
    {
        Task<IEnumerable<Cliente>> getClientes();
        Task<Cliente> getClienteById(int id);
        Task<bool> insertCliente(Cliente cliente);
        Task<bool> UpdateClientes(Cliente cliente);
        Task<bool> deleteCliente(int id);
    }
}
