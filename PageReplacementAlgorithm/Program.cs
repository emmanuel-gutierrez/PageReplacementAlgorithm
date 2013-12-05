using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageReplacementAlgorithm
{


    class Program
    {
        static void Main(string[] args)
        {
            int[,] leMatrix;
            Console.WriteLine("Of what dimension would you like the matrix to be?");
            int size = int.Parse(Console.ReadLine());
            leMatrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    leMatrix[i, k] = 0;
                    Console.Write(0+" ");
                }
                Console.Write("\n");
            }

            while (true)
            {
                Console.WriteLine("In which section would you like to apply NRU? ");
                int section = int.Parse(Console.ReadLine());
                for (int i = 0; i < size; i++)
                {
                    leMatrix[section, i] = 1;
                }
                for (int k = 0; k < size; k++)
                {
                    leMatrix[k, section] = 0;
                }


                for (int i = 0; i < size; i++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        Console.Write(leMatrix[i, k]+" ");
                    }
                    Console.Write("\n");
                }
            }
        }

    }
}
