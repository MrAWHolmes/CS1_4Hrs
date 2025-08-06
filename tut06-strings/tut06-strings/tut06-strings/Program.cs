namespace tut06_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string message = "This is a string y'all!";


            Console.WriteLine($"message = {message}");
            Console.WriteLine($"message.ToUpper() = {message.ToUpper()}");
            Console.WriteLine($"message.ToLower() = {message.ToLower()}");
            Console.WriteLine($"message.Length = {message.Length}");
            Console.WriteLine($"message.Contains(\"string\") = {message.Contains("string")}");
            Console.WriteLine($"message.IndexOf(\"string\" = {message.IndexOf("string")}");
            Console.WriteLine($"message.Substring(5) = {message.Substring(5)}");
            Console.WriteLine($"message.Substring(message.Length-5) = {message.Substring(message.Length-5)}");

            Console.WriteLine($"{{string.Join(\", \",message.Split(' '))}} = {{{string.Join(", ",message.Split(' '))}}}");

        }
    }
}
