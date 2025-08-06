namespace tut4_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adult = "woman";
            string name = "Lilly";
            string proNoun = "She";
            int age = 90;

            Console.WriteLine($"There once was a {adult} named {name},");
            Console.WriteLine($"\t{proNoun} was {age} years old.");
            Console.WriteLine($"{proNoun} really liked the name {name},");
            Console.WriteLine($"\tbut didn't like being {age}!");

            Console.ReadLine();
        }
    }
}
