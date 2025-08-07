namespace Tut08_UserInput
{ /*
   *  Cool Reference : https://csharp-book.softuni.org
   */
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.Write("What is your name? ");
            name = Console.ReadLine();

            Console.Write("How old are you? ");
            age = int.Parse(Console.ReadLine());

            Console.Write("What is your GPA? ");
            var gpa = float.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name + " you are " + age + " years old.");
            Console.WriteLine("You have a gpa of " + gpa);
            
        }
    }
}
