using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace REFORZANDO
{
    internal class Ejercicio3
    {
        static void Main(string[] args) 
        {
            string[] Estudiantes = new string[6] { "Elena", "Mario", "Ricardo", "Jhon", "Tina", "Guille" };
            int[] Promedio = new int[6] {20,13,15,10,8,16 };
            
            while (true)
            {
                Console.WriteLine("\nLista de estudiantes: ");
                foreach (string Alumnos in Estudiantes)
                    Console.WriteLine(Alumnos);


            
                Console.Write("\nIngrese un nombre: ");
                string Buscando = Console.ReadLine();
                Console.Clear();

                int índice = Array.IndexOf(Estudiantes, Buscando);

                if (índice != -1)
                {
                    Console.Write("\nSu actual promedio es: " + Promedio[índice]);

                    while (true)
                    {
                        Console.Write("\nIngrese el nuevo promedio (0 - 20) : ");
                        int nuevoPromedio = Convert.ToInt32(Console.ReadLine());

                        if (nuevoPromedio <= 20 && nuevoPromedio >= 0)
                        {
                            Promedio[índice] = nuevoPromedio;
                            Console.WriteLine("\nPromedio modificado. ");
                            break;

                        }

                        else
                        {
                            Console.WriteLine("\nERRROR. Ingrese un valor correcto...");
                            continue;
                        }
                    }
                    break;

                }

                else
                {
                    Console.WriteLine("\nEl nombre no se encuentra en la lista. ");
                    Console.WriteLine("\nPresione una tecla para volver a intentarlo...");
                    Console.ReadKey();
                }
            }



        }
    }
}
