using System;
using System.Linq;

namespace ProbabilidadDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados();
        }

        private static void Dados()
        {
            int numero = 0;
            double probabilidad = 0.0;

            int[] lista = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Inserete un numero: ");
            numero = Convert.ToInt32(Console.Read());

            Console.WriteLine("Inserete la probabilidad: ");
            probabilidad = Convert.ToDouble(Console.Read());

            Console.ReadKey();

            for (int i = 0; i < lista.Count(); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
