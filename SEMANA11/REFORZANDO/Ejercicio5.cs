using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace REFORZANDO
{
    internal class Ejercicio5
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("     AGENDA DE NEGOCIO - CLIENTES      ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" [1] - Registrar Nuevo Cliente");
            Console.WriteLine(" [2] - Modificar Clientes");
            Console.WriteLine(" [3] - Listar Clientes");
            Console.WriteLine("---------------------------------------");
            Console.Write("\nIngrese una de las opciones: ");
            int opciones = Convert.ToInt32(Console.ReadLine());

            switch (opciones) 
            {
                case 1:
                    RegistrarCliente();
                    break;
                case 2:
                    ModificarClientes();
                    break;
                case 3:
                    ListarClientes();
                    break;

                default:
                    Console.WriteLine("ERROR. Ingreso una opción inválida. ");
                    break;
            }
        }

        static void RegistrarCliente() 
        {
            Console.Clear();
            string[] Nombre_Cliente = new string[10];
            int[] DNI_Cliente = new int[10];
            int Contador = 0, ContadorÍndice = 0;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("       REGISTRAR NUEVO CLIENTE         ");
            Console.WriteLine("---------------------------------------");

            for (ContadorÍndice = 0; ContadorÍndice < 10; ContadorÍndice++)
            {
                Console.Write("\nIngrese DNI del cliente: ");
                DNI_Cliente[ContadorÍndice] = Convert.ToInt32(Console.ReadLine());

                do
                {
                    foreach (int c in DNI_Cliente)
                    {
                        ContadorÍndice += 1;
                    }

                    if (ContadorÍndice != 8)
                    {
                        Console.WriteLine("Debe ingresar un DNI válido (8 dígitos). Intente nuevamente.\n");
                        Contador = 0;
                    }

                } while (ContadorÍndice == 0);
            }
            
            

            Console.Write("\nIngrese nombre del cliente: ");
            foreach (string Nombre in Nombre_Cliente)
                Console.WriteLine(Nombre);

            string Buscando = Console.ReadLine();
            Console.Clear();

            int índice = Array.IndexOf(Nombre_Cliente, Buscando);


            Console.Write("\nIngrese teléfono del cliente: ");
            int numero = Convert.ToInt32(Console.ReadLine());


        }

        static void ModificarClientes() 
        {
            Console.Clear();
        }

        static void ListarClientes()
        {
            Console.Clear();
        }
    }
}
