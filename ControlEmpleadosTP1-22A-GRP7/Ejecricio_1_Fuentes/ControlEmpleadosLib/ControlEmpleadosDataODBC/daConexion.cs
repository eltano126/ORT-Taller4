using System;
using System.Data;
using System.Data.Odbc;
using ControlEmpleadosData;
using System.Configuration;

namespace ControlEmpleadosDataODBC
{
	/// <summary>
	/// Esta clase es solo de uso interno en la librer�a por este
	/// motivo se antepone la palabra reservada "internal".
	/// </summary>
	internal class daConexion
	{
		/// <summary>
		/// Obtener una conexi�n abierta a la base de datos utilizando ODBC.
		/// </summary>
		/// <returns>Una conexi�n abierta a la base de datos.</returns>
		public IDbConnection GetOpenedConnection()
		{
            OdbcConnection connection = new OdbcConnection("DSN=ControlEmpleados");
			connection.Open();

			return connection;
		}
	}
}

