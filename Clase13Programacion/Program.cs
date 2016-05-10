using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoComestible UnProducto = new ProductoComestible("Franco", 1111);
            Producto Prod = new Producto(2222, "Fran");
            ProductoComestibleVencido ProdVen = new ProductoComestibleVencido(UnProducto);
            ProductoDeLimpieza ProdLimpieza = new ProductoDeLimpieza(TipoProductos.Limpieza, 3333, "Ayudin");

            //UnProducto.Mostrar();

            List<Producto> listado = new List<Producto>();

            listado.Add(UnProducto);
            listado.Add(Prod);
            listado.Add(ProdVen);
            listado.Add(ProdLimpieza);

            foreach (Producto item in listado)
            {
                item.Mostrar();
            }

            Console.ReadLine();
        }
    }
}
