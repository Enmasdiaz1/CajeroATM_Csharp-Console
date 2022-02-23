using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenParcial
{
    class ModoHojas500 : IValidar
    {

		public int Cant { get; set; }

		public ModoHojas500(int cant)
		{
			Cant = cant;
			Devolviendo();
		}

		public void Devolviendo()
		{
			if (ValidandoRetorno(Cant))
			{
				var hojas = Devuelta(Cant);

				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\nESTE CAJERO ESTA DEVOLVIENDO ");

				Console.WriteLine(" \nEN HOJAS DE 100... " + hojas[0] +
								  " \nEN HOJAS DE 500... " + hojas[1] );
				Console.ForegroundColor = ConsoleColor.White;

			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\nError, debe ingresar una cantidad valida");
				Console.ResetColor();
				Console.ReadKey();
			}
		}
		public bool ValidandoRetorno(int cant)
		{
			if (cant % 100 == 0 || cant % 500 == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public int[] Devuelta(int cant)
		{
			int[] hojas = { 0, 0 };
			while (cant > 0)
			{
				if (cant >= 500)
				{
					hojas[1]++;
					cant -= 500;
				}
				else if (cant >= 100)
				{
					hojas[0]++;
					cant -= 100;
				}

			}
			return hojas;
		}
	}
}
