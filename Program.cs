
using System;

namespace ejercicios
{
    class Program
    {
        static void Main()
        {
            int numeroMayor = 0;
            int[] numerosEnteros = new int[10];

            //los cargamos con un for
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                numerosEnteros[i] = int.Parse(Console.ReadLine());
            }

            //creamos una variable bandera para guardar el mayor, y con un for
            //recorremos la lista para ir comparando con el mayor

            for (int x = 0; x < 10; x++)
            {
                if (numerosEnteros[x] > numeroMayor)
                {
                    numeroMayor = numerosEnteros[x];
                }
                else
                {
                    Console.WriteLine($"el valor {numeroMayor} no fue superado");
                }
            }

            Console.WriteLine($"el numero mayor es :{numeroMayor}");
        }
    }
}
