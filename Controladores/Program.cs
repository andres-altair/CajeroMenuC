using CajeroMenuC.Servicios;

namespace CajeroMenuC.Controladores
{
    /// <summary>
    /// clase principal de la aplicacion
    /// 250923-amd
    /// </summary>
    class Program
    {
        /// <summary>
        /// metodo de etrada de la aplicacion
        /// 250923
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {


            MenuInterfaz menuInterfaz = new MenuImplementacion();
            menuInterfaz.mostrarMensajeBienvenida();
            //Variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;

            //Va a contener la opcion seleccionada
            int opcionSeleccionar;

            //Si da true dentro, entrara, si no, no
            //Desde la primera iteracion debe cumplirse la condicion
            while (!cerrarMenu)
            //tambien esta el do while

            {
                opcionSeleccionar = menuInterfaz.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionar);
                //coge la opcion del usuario y la copia en la opcion seleccionada

                switch (opcionSeleccionar)
                //el while y switch van juntos
                {
                    case 0:
                        Console.WriteLine("[INFO] - se ejecuta caso 0.");
                        cerrarMenu |= true;

                        break;//Sirve para que se salga del switch y vaya a la siguiente linea
                    case 1:
                        Console.WriteLine("[INFO] - se ejecuta caso 1.");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - se ejecuta caso 2.");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - se ejecuta caso 3.");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - se ejecuta caso 4.");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] - se ejecuta caso 5.");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no esta disponible.");
                        //este sirve para dar una informacion
                        break;
                }



            }
        }
    }
}
