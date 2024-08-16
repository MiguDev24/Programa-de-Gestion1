using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsessLogic;
using Entity;

namespace Bll
{
    public class Bll_Inventario
    {
        private Dall_Inventario dall_Inventario= new Dall_Inventario();
        public DataTable Mostrar_Inventario()
        {
            return dall_Inventario.Mostrar_Inventario();
        }
        public bool Agregar_Articulo(Inventario inventario)
        {
            return dall_Inventario.Agregar_Articulo(inventario);
        }   
        public bool Eliminar_Articulo(int idarticulo)
        {
            return dall_Inventario.Eliminar_Articulo(idarticulo);
        }
        public bool Modificar_Articulo(Inventario inventario)
        {
            return dall_Inventario.Modificar_Articulo(inventario);
        }
        public bool ArticuloRepetido(int idarticulo)
        {
            return dall_Inventario.ArticuloRepetido(idarticulo);
        }
    }
}
