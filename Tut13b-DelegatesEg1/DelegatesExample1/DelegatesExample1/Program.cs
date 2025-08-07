namespace DelegatesExample1
{
    //delegate should be declared outside the class
    public delegate void MyDelegate(string msg); // declare the delegate

    internal class Program
    {

        static TaDa TaDaObject;

        static void LocalMethod(string msg)
        {
            Console.WriteLine("You called LocalMethod:");
            Console.WriteLine(msg);
            Console.WriteLine();
        }

        static MyDelegate LambdaFunc = (string msg) =>
        {
            Console.WriteLine("Im the lambda function:");
            Console.WriteLine(msg);
            Console.WriteLine();
        };

        static void Main(string[] args)
        {
            MyDelegate[] Callbacks = {LocalMethod,LambdaFunc,  TaDaObject.SayHi };

            for (int i = 0; i < Callbacks.Length; i++)
            {
                Callbacks[i]($"Called from Callable[{i}]");
            }
        }

        class TaDa
        {
            public static void sayHi(string msg)
            {
                Console.WriteLine("Hello from class TaDa!");
                Console.WriteLine(msg);
                Console.WriteLine();
            }
        }
    }
}
