using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13Programacion
{
    public sealed class ProductoComestibleVencido:ProductoComestible
    {
        /*Atributos*/
        public ProductoComestible PrimerProducto;

        /*Constructores*/
        public ProductoComestibleVencido(ProductoComestible Prod):base(Prod.Nombre, Prod.Codigo, Prod.FechaVencimiento)
        {
            this.PrimerProducto = Prod;
        }
    }
}
