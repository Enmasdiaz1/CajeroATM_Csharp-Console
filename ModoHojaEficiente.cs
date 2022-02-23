using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenParcial
{
    class ModoHojaEficiente : IValidar
	{
		public int Cant { get; set; }

		public ModoHojaEficiente(int cant)
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

				Console.WriteLine(" \nEN HOJAS DE 1000... " + hojas[1] +
								  " \nEN HOJAS DE  200... " + hojas[0]+
								  " \nEN HOJAS DE  500... " + hojas[2]+
								  " \nEN HOJAS DE  100... " + hojas[3]);
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
			if (cant % 200 == 0 || cant % 1000 == 0 || cant % 100 == 0 || cant % 500 == 0)
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
			int[] hojas = { 0, 0, 0, 0 };
			while (cant > 0)
			{
				if (cant >= 1000)
				{
					hojas[1]++;
					cant -= 1000;
				}
				else if (cant >= 500)
				{
					hojas[2]++;
					cant -= 500;
				}
				else if (cant >= 200)
				{
					hojas[0]++;
					cant -= 200;
				}
				else if (cant >= 100)
				{
					hojas[3]++;
					cant -= 100;
				}

			}
			return hojas;
		}
	}
}
