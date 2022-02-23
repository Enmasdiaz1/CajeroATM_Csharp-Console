using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenParcial
{
    public class MenuPrincipal
    {

        public static int operacion = 3;
        public static int cant;

        IValidar LaOperacion;


        public void ImprimirMenuPrincipal()
        {
            
           
            try
            {
                Console.Clear();


                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nBIENVENIDO\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1-Modo Dispensacion\n2-Retiro de Dinero\n\n3-Salir\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione una opcion");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                   case (int)OpcionesMenuPrincipal.Dispensacion:
                        MenuDispensacion menuDispensacion = new MenuDispensacion();
                        menuDispensacion.ImprimirMenuDispensacion();                        
                        break;
                    case (int)OpcionesMenuPrincipal.Retirar:

                        string continuar;

                        do
                        {

                            Console.Write("\nIngrese la cantidad que desea retirar: ");
                            int cant = Convert.ToInt32(Console.ReadLine());
                            if (operacion == 1)
                            {
                                LaOperacion = new ModoHojas200(cant);
                            }else if (operacion == 2)
                            {
                                LaOperacion = new ModoHojas500(cant);
                            }else if (operacion == 3)
                            {
                                LaOperacion = new ModoHojaEficiente(cant);
                            }

                            Console.Write("\n¿Desea seguir retirar mas? (S/N): ");
                            continuar = Console.ReadLine();

                        } while (continuar == "S" || continuar=="s");

                        ImprimirMenuPrincipal();

                        Console.ReadKey();

                        break;

                    case (int)OpcionesMenuPrincipal.Salir:
                        Console.WriteLine("Usted esta abandonando el sistema\n" +
                            " ¡Gracias por usar nuestro sistema!");
                        Console.ReadKey();

                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Debe colocar una opcion valida");
                        Console.ReadKey();
                        ImprimirMenuPrincipal();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debe colocar una opcion valida");
                Console.ReadKey();
                ImprimirMenuPrincipal(); 
            }
        }
    }
}
