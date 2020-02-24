using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int buscado = 7;
            if (Buscar(buscado,numeros))
            {
                Console.WriteLine("Numero Encontrado");
            }
            Console.ReadKey();

            List<string> nombres = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                nombres.Add("Estudiante " + i);
            }
            nombres.Remove("Estudiante 3");
            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static bool Buscar(int buscado, int[] numeros)
        {
            bool resultado = false;
            for (int i = 0; i < numeros.Length; i++)
            {
                
                if (buscado==numeros[i])
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }
    }
}
