using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repositorio
{
    public interface IEmpleadoRepositorio
    {
        Task<IEnumerable<empleado>> getEmpleado();
        Task<empleado> getEmpleadoById(int id);
        Task<bool> insertEmpleado(empleado empleado);
        Task<bool> UpdateEmpleado(empleado empleado);
        Task<bool> deleteEmpleado(int id);
    }
}
