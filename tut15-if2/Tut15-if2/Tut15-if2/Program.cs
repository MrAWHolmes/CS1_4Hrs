using System.Numerics;
using System.Threading.Channels;

namespace Tut15_if2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = ReadInt("Enter value for A");
            int B = ReadInt("Enter value for B");
            int C = ReadInt("Enter value for C");

            int maxValue = GetMaxInt(GetMaxInt(A, B), C);

            Console.WriteLine($"GetMaxInt({A},{B},{C}) = {maxValue}");
        }


        static int ReadInt(string prompt)
        {
            Console.Write(prompt + ": ");
            return int.Parse(Console.ReadLine());
        }
        static int GetMaxInt(int A, int B)
        {
            if (A > B) return A; else return B;

        }
    }
}
