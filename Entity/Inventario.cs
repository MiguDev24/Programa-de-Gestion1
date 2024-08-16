using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Inventario
    {
        public int id_articulo { get; set; }
        public string Nombre_Articulo { get; set; }
        public string Descripccion { get; set; }
        public string Marca { get; set; }
        public string Precio { get; set; }
        public int Stock { get; set; }
    }
}
