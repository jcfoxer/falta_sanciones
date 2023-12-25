using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consola_de_medicion_tiempo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declaramos una lista de enteros
            List<int> numeros = new List<int>();

            // Agregamos 10 números por teclado a la lista
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número:");
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }

            // Contamos los números que son menores que 10
            int numerosMenoresQue10 = 0;
            foreach (int numero in numeros)
            {
                if (numero < 10)
                {
                    numerosMenoresQue10++;
                }
            }

            // Contamos los números que son menores que 15
            int numerosMenoresQue15 = 0;
            foreach (int numero in numeros)
            {
                if (numero < 15)
                {
                    numerosMenoresQue15++;
                }
            }

            // Contamos los números que son mayores que 15
            int numerosMayoresQue15 = 0;
            foreach (int numero in numeros)
            {
                if (numero > 15)
                {
                    numerosMayoresQue15++;
                }

                // Calculamos el promedio de la lista de números
                double promedio = 0;
                int total = numeros.Sum();
                if (numeros.Count > 0)
                {
                    promedio = total / numeros.Count;
                }





                // Imprimimos los resultados
                Console.WriteLine("Hay {0} números menores que 10.", numerosMenoresQue10);
                Console.WriteLine("Hay {0} números menores que 15.", numerosMenoresQue15);
                Console.WriteLine("Hay {0} números mayores que 15.", numerosMayoresQue15);

            }

            Console.ReadKey();

            }
    }
}
