using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13Programacion
{
    class ProductoComestible:Producto
    {
        /*Atributos*/
        private DateTime _fechaVencimiento;        

        /*Constructores*/
        public ProductoComestible(string Nombre, int Codigo):base(Codigo, Nombre)//llamando constructor
        {
            //Hay que llamar al constructor de la clase base.
        }

        public ProductoComestible(string Nombre, int Codigo, DateTime fechaVto):this(Nombre, Codigo)
        {
            this._fechaVencimiento = fechaVto;
        }

        /*Propiedades*/
        public DateTime FechaVencimiento
        {
            get { return _fechaVencimiento; }
        }
    }
}
