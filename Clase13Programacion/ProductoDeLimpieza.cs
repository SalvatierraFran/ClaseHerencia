using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13Programacion
{
    class ProductoDeLimpieza:Producto
    {
        /*Atributos*/
        public TipoProductos ProdLimpieza;

        /*Constructores*/
        public ProductoDeLimpieza(TipoProductos Tipo, int cod, string nombre):base(cod, nombre)
        {
            this.ProdLimpieza = Tipo;
        }
    }

    public enum TipoProductos
    {
        Limpieza, Desinfeccion, LimpiezaYDesinfeccion
    }
}
