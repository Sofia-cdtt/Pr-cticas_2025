using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace REFORZANDO
{
    internal class Ejercicio2
    {
        static void Main(string[] args) 
        {
            // Se pide crear un programa que nos permita ingresar el nombre de los
            // productos y guardarlos en un arreglo.El nombre del producto debe
            // ser único y no debe repetirse en el arreglo y si hay algún valor que se
            // repite, se debe volver a ingresar.
            // Observación: Utilice un arreglo del tamaño de 10.

            string[] NombreProductos = new string[10];
            int registro = 0;

            for (int i = 0; registro < NombreProductos.Length; i++) 
            {
                Console.Write("Ingrese el nombre los productos: ");
                string Nombres = Console.ReadLine();
                bool repetir = false;
                for (int j = 0; j < Nombres.Length; j++) 
                {
                    if (NombreProductos[j] == Nombres) 
                    {
                        Console.WriteLine("\nEl producto ingresado ya existe. ");
                        repetir = true;
                        break;
                    }
                }
                
                if (repetir == false) 
                {
                    NombreProductos [registro] = Nombres;
                    registro++;
                }
            }

            Console.WriteLine("\nLa lista de productos es: ");
            foreach (string i in NombreProductos)
                Console.WriteLine(i);

            Console.ReadKey();  
            
        }

    }
}
