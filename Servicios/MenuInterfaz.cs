using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    /// <summary>
    /// interfaz con la relacion de metodos de la funcionalidad menu
    /// 250923-amd
    /// </summary>
    internal interface MenuInterfaz
    {

        /// <summary>
        /// metodo que muestra mensaje de bienvenida al cajero
        /// </summary>

        public void mostrarMensajeBienvenida();
        /// <summary>
        /// metodo qyue muetra el menu y recoge la seleccion del usuario
        /// 260923-amd
        /// </summary>
        /// <returns></un entro con la opcion selecionada </returns>
        public int mostrarMenuYSeleccion();

    }
}
