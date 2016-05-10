using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13Programacion
{
    class Producto
    {
        //Hacer ejercicio 41 y 42 para mañana, miercoles 11 de mayo.

        /*Atributos*/
        private int codigo;        
        protected string nombre; //Dentro de mi clase lo puedo ver. Fuera, no. Objeto.nombre no se puede acceder.      

        /*Constructores*/
        public Producto(int cod)
        {
            this.codigo = cod;
        }

        public Producto(int cod, string Nombre):this(cod)
        {
            this.nombre = Nombre;
        }

        /*Metodos*/
        public void Mostrar()
        {
            Console.WriteLine("Codigo: " + this.codigo + "\nNombre: " + this.nombre);
            Console.WriteLine();
        }

        /*Propiedades*/
        public int Codigo
        {
            get { return codigo; }
        }

        public string Nombre
        {
            get { return nombre; }
        }
        
        //Objetivo principal de Herencia es la reutilización de código.
        //Cuando genero una herencia lo más dificil es respetar las reglas.
        //Si son atributos privados no se van a poder ver.
        //Protected, lo pueden ver todos los que heredan de esa clase. Clase e hijas.
        //Public, lo puede ver cualquiera.
        //Private, solo para la clase.
    }
}
