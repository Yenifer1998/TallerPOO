using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadPOO
{
    public class Empleado
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public List<Articulo> Articulos { get; set; }
    }
}
