using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenParcial
{

    public class MenuDispensacion
    {

        MenuPrincipal main = new MenuPrincipal();
        public void ImprimirMenuDispensacion()
        {

            try
            {
                Console.Clear();

                MenuPrincipal menuPrincipal = new MenuPrincipal();
                

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDispansacion de Dinero\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1-MODO DE 200 & 1000\n2-MODO DE 100 & 500\n3-MODO EFICIENTE (LA MENOR CANTIDAD DE PAPELETAS)\n\n" +
                    "4-Volver atras\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Seleccione una opcion");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case (int)OpcionesRetiro.Mood200:                        
                        MenuPrincipal.operacion = 1; 
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("USTED HA SELECCIONADO EL MODO 200 Y 1000" +
                            "\n\n¡SELECCION GUARDADA CON EXITO!");
                        Console.ReadKey();
                        main.ImprimirMenuPrincipal();

                        break;
                    case (int)OpcionesRetiro.Mood500:
                        MenuPrincipal.operacion = 2;
                        Console.ForegroundColor = ConsoleColor.Green;
                         Console.WriteLine("USTED HA SELECCIONADO EL MODO 100 Y 500" +
                             "\n\n¡SELECCION GUARDADA CON EXITO!");
                        Console.ReadKey();
                        main.ImprimirMenuPrincipal();
                        break;
                    case (int)OpcionesRetiro.Default:
                        MenuPrincipal.operacion = 3;
                        Console.ForegroundColor = ConsoleColor.Green;
                         Console.WriteLine("USTED HA SELECCIONADO EL MODO EFICIENTE" +
                             "\n\n¡SELECCION GUARDADA CON EXITO!");
                        Console.ReadKey();
                        main.ImprimirMenuPrincipal();

                        break;
                    case (int)OpcionesRetiro.Back:
                        main.ImprimirMenuPrincipal();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Debe colocar una opcion valida");
                        Console.ReadKey();
                        ImprimirMenuDispensacion();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debe colocar una opcion valida");
                Console.ReadKey();
                ImprimirMenuDispensacion();
            }
        }
    }
}
