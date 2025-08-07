namespace Tut13_Returns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i,3}^3 = {cube(i),5}");
            }

            Console.ReadKey();  
        }

        static int times(int a, int b)
        {
            return a * b;
        }
        static int cube(int num)
        {
            return times(times(num, num), num);
        }
    }
}
