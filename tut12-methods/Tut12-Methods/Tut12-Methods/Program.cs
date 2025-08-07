namespace Tut12_Methods
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi("Fred");

            Console.ReadKey();
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hello , "+name);
        }
    }
}
