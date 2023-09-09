using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repositorio
{
    public interface IVentasRepositorio
    {
        Task<IEnumerable<ventas>> getVentas();
        Task<bool> insertVentas(ventas venta);
        
    }
}
