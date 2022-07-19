using System;

namespace Vetor_Aula
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            double media = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o peso " + (i + 1) + ":");
                vect[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("Peso " +(1+i) + ": " + vect[i].ToString("F2") + " KG" + "\n" );
                 media+= vect[i] / n;
                
            }

            Console.WriteLine("Média dos pesos: " + media + " KG");

        }
    }
}
