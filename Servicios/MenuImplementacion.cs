using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
       
        /// <summary>
        /// clase que implementa la interfaz de menu
        /// 250923-amd
        /// </summary>


        public void mostrarMensajeBienvenida()
        {
            string mensaje = "Banco de csi1";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;

            Console.WriteLine("***********************************************");
            Console.WriteLine("0. Cerrar aplicacion ");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Ingresar dinero");
            Console.WriteLine("3. Sacar dinero ");
            Console.WriteLine("4. Trasnferencia");
            Console.WriteLine("5. Historial de operaciones");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Selecione una opcion");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;


        }

    }

}
