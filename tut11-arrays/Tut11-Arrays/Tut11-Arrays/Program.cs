using System.Runtime.CompilerServices;

namespace Tut11_Arrays
{
    internal class Program
    {
        static int[] GeneratePrimes(int stop)
        {
            int[] Primes = { };

            for (int x = 2; x <= stop; x++)
            {
                bool hasFactors = false;
                int i = 0;

                while (!hasFactors && i < Primes.Length)
                {
                    hasFactors = (x % Primes[i] == 0);
                    i++;
                }

                if (!hasFactors)
                {
                    Primes = Primes.Append(x).ToArray();
                }
            }
            return Primes;
        }

        static void PrintArray<T> (T[] L)
        {
            if (L == null) { return; }

            string s = "{";

            s += String.Join(", ",L);

            s += "}";

            Console.WriteLine(s);            }
        static void Main(string[] args)
        {
            int[] Primes100 = GeneratePrimes(100);
            Console.WriteLine("Primes under 100:");
            PrintArray(Primes100);

            string[] Languages = new string[5];
            Languages[0] = "Turbo Pascal";
            Languages[1] = "Delphi";
            Languages[2] = "Python 3";
            Languages[3] = "C#";
            Languages[4] = "Java";

            Console.WriteLine("Coding Languages:");
            PrintArray(Languages); 
            Console.ReadKey();
        }
    }
}
