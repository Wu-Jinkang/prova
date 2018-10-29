using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inizialiazzaione
            int[] V = new int[10];
            //Input
            for (int i = 0; i < 10; i++)
            {
                Console.Out.WriteLine("Inserisci un numero: ");
                V[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Chiama la funzione
            Ordinamento(V);
            //Output
            Console.WriteLine("l'Output: ");
            for (int i = 0; i < V.Length; i++)
            {
                Console.Out.WriteLine(V[i]);
            }
            Console.ReadLine();
        }
        static int Max(int[] array)
        {
            int max;
            max = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        static int Min(int[] array)
        {
            int min;
            min = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        static void Ordinamento(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}