using System;
using System.Collections.Generic;
using System.Text;

namespace ControlEmpleadosData
{
    /// <summary>
    /// Clase base de excepci�n de error de base de datos.
    /// </summary>
    public class daException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ex">Excepci�n original</param>
        public daException(Exception ex) : base("Se produjo un error en la base de datos.", ex)
        { 
        }
    }
}
