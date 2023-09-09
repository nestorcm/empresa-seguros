using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class ventas
    {
        public int id { get; set; }
        public int idcliente { get; set; }
        public int tiposeguro { get; set; }
        public int idempleado { get; set; }
        public string fechaInicioSeguro { get; set; }
        public string fechaFinalSeguro { get; set; }
        public bool venta { get; set; }
    }
}
