using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenParcial
{
    public class ModoHojas200 : IValidar
	{
		public int Cant { get; set; }

		public ModoHojas200(int monto)
		{
			Cant = monto;
			Devolviendo();
		}

		public void Devolviendo()
		{
			Console.WriteLine(Cant);

			if (ValidandoRetorno(Cant))
			{
				var hojas = Devuelta(Cant);

				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\nESTE CAJERO ESTA DEVOLVIENDO ");

				Console.WriteLine(" \nEN HOJAS DE 1000... " + hojas[1] +
								  " \nEN HOJAS DE  200... " + hojas[0] );
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
			if (cant % 200 == 0 || cant % 1000 == 0)
			{
				return true;
            }
            else
            {
				return false;
			}
		}
		public  int[] Devuelta(int cant)
		{
			int[] hojas = { 0, 0 };
			while (cant > 0)
			{
				if (cant >= 1000)
				{
					hojas[1]++;
					cant -= 1000;
				}else if (cant >= 200)
				{
					hojas[0]++;
					cant -= 200;
				}
				
			}
			return hojas;
		}
	}

}
