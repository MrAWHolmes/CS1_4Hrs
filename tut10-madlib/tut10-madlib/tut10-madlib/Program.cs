namespace tut10_madlib
{
    internal class Program
    {
        static string ReadLineString(string prompt="",bool allowEmpty=false)
        {
            string? data = "";
            int enterCount = 0;

            while(enterCount == 0)
            {
                Console.Write(prompt + " ?: ");
                data = Console.ReadLine();
                
                if (data != null && (allowEmpty || data?.Length > 0)){
                    enterCount++;
                }
            }
            return data != null ? data : ""; // terniary if (data != null){ return data} else {return ""};
        }
        static string RemoveLeadingSpaces(string s)
        {
            while (s.Length > 0 && s[0] ==' ')
            {
                s = s.Substring(1); // remove leading spaces
            }
            return s;
        }
        static string ToTitle(string s)
        {
            if (s==null || s.Length == 0) { return ""; }

            s = RemoveLeadingSpaces(s);
            s = s[0].ToString().ToUpper() + s.Substring(1);

            int x = 0;
            while (x > 0 && x < s.Length){
                if (x + 1 < s.Length)
                {
                    s = s.Substring(x) + s.Substring(x + 1, 1).ToUpper() + s.Substring(x + 2);
                    x = s.IndexOf(" ", x + 1);
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            string colour, pluralNoun, celebrity;
            //Console.Write("Enter a colour      : ");
            colour = ReadLineString("Enter a colour      : ");
            colour = RemoveLeadingSpaces(colour);
            colour = colour.ToLower();
            
            //Console.Write("Enter a plural noun : ");
            pluralNoun = ToTitle(ReadLineString("Enter a plural noun : ").ToLower());
            //pluralNoun = pluralNoun.ToLower();
            //pluralNoun = ToTitle(pluralNoun);

            //Console.Write("Enter a celebrity   : ");
            celebrity = ToTitle(ReadLineString("Enter a plural noun : ").ToLower());
            

            Console.WriteLine($"Roses are {colour},");
            Console.WriteLine($"{pluralNoun} are blue,");
            Console.WriteLine($"I love {celebrity}.");
        }
    }
}
