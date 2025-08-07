namespace tut07_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;
            float c = 50.0f;
            double d = 42.24;
            decimal de = 100.0M;

            Console.WriteLine($"{a} * {b} = {a*b}");
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");

            Console.WriteLine($"{c} / {b} = {c / b}");
            Console.WriteLine($"{c} % {b} = {c % b}");

            Console.WriteLine($"{d} / {b} = {d / b}");
            Console.WriteLine($"{d} % {b} = {d % b}");

            Console.WriteLine($"{de} / {b} = {de / b}");
            Console.WriteLine($"{de} % {b} = {de % b}");

            Console.WriteLine($"{c} / {b})               = {c / b}");
            Console.WriteLine($"Math.Truncate({c} / {b}) = {Math.Truncate(c / b)}");
            Console.WriteLine($"Math.Round({c} / {b})    = {Math.Round(c / b)}");
            Console.WriteLine($"Math.Sqrt({a}^2 + {b}^2) = {Math.Sqrt(a^2 + b^2)}");
        }
    }
}
