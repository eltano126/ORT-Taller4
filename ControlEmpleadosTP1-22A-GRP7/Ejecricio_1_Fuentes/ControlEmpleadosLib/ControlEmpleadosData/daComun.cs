using System;

namespace ControlEmpleadosData
{
	/// <summary>
	/// Clase con m�todos, propiedades y constantes globales al proyecto 
	/// ControlEmpleadosData.
	/// Esta clase es solo de uso interno en la librer�a por este
	/// motivo se antepone la palabra reservada "internal".
	/// </summary>
	public class daComun
	{
		/// <summary>
		/// El constructor se declara privado porque esta clase no debe
		/// ser instanciada.
		/// </summary>
		private daComun()
		{
		}

		public enum TipoComandoEnum
		{
			Insertar,
			Actualizar,
			Eliminar
		}
	}
}
