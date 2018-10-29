/*
 * Wu Jinkang
 * 5A IA
 * 29/10/2018
 * */
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
        /*
         * Funzione Avg 
         * input: array di interi
         * output: valore media dell'array
         * */
        static int Avg(int[] array)
        {
            int avg = 0;
            for (int i = 0; i < 10; i++)
            {
                avg += array[i];
            }
            avg /= 10;
            return avg;
        }
        /*
         * Funzione Max
         * input: array di interi
         * output: valore massimo dell'array
         * */
        static int Max(int[] array)
        {
            int max = 0;
            max = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        /*
         * Funzione Min
         * input: array di interi
         * output: il valore minimo dell'array
         * */
        static int Min(int[] array)
        {
            int min = 0;
            min = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        /*
         * Funzione Ordinamento
         * input: array di interi
         * output: l'array di interi ordinato decrescente
         * */
        static void Ordinamento(int[] array)
        {
            int temp = 0; 
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