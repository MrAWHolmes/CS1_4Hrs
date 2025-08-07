namespace tut09_calc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;


            Console.Write("Enter integer 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter integer 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // fun fact! if now () around addition num1+num2 it concatenates!

            Console.WriteLine(num1 + " + " + num2 + " = " + (num1+num2));

            Console.ReadLine();
        }
    }
}
