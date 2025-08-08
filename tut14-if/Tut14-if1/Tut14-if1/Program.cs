

namespace Tut14_if1
{
    internal class Program
    {

        public static TResult[] Map <TSource, TResult>(TSource[] source, Func<TSource,TResult> selector)
        {
            return source.Select(selector).ToArray();
        }
        
        public const int CurrentYear = 2025;
        static int MaxMonthDay(int month,int year)
        {
            //Leap years are multiples of 4       
            bool isLeapYear = (year % 4 == 0);

            //30 day months
            int[] ThirtyDays = { 9, 4, 6, 11 };

            if (Array.IndexOf(ThirtyDays,month) >=0)
            {
                return 30;
            }

            if (month == 2 )
            {
                return isLeapYear ? 29 : 28;
            }

            return 31;
        }

        static char? GetSeperator(string ddmmyyyy)
        {
            char? seperator = null;
            
            if (ddmmyyyy.IndexOf(' ') > 0)   return ' ';


            if (ddmmyyyy.IndexOf('-') > 0) return '-';

            if (ddmmyyyy.IndexOf('/') > 0) return '/';

            if (ddmmyyyy.IndexOf('.') > 0) return '.';

            return null;
        }
        

        static int[] SplitDate(string ddmmyyyy)
        {
            int[] L = new int[3]; // create a 3 element array

            // split date if seperator detected
            char? seperator = GetSeperator(ddmmyyyy);

            if (seperator.HasValue)
            {
                //Map(list,function)
                // to prevent nullable error make pure char copy of seperator
                char sep = seperator.Value;

                // method 1 : pure .Select(function).ToArray();
                L = ddmmyyyy.Split(sep).Select(int.Parse).ToArray();

                //Method 2 - Custom Map method
                //L = Map(ddmmyyyy.Split(seperator), int.Parse);
            }
            else
            {
                L[0] = int.Parse(ddmmyyyy.Substring(0, 2));
                L[1] = int.Parse(ddmmyyyy.Substring(2, 2));
                L[2] = int.Parse(ddmmyyyy.Substring(4));
            }

            return L;
        }

        static bool DateFormatIsValid(string ddmmyyyy)
        {
            int[] L = SplitDate(ddmmyyyy);

            if (L[2] < 1000 || (L[2]) > CurrentYear) return false;

            if (L[1] < 1 || L[1] > 12) return false;

            if (L[0] < 1 || L[0] > MaxMonthDay(L[0], L[1])) return false;

            return true;
        }
        static string ExplodeDate(string ddmmyyyy)
        {
            int[] L = SplitDate(ddmmyyyy);

            string dd, mmmm, yyyy;

            dd = L[0].ToString();

            mmmm = "";
            switch (L[1])
            {
                case 1: mmmm = "January"; break;
                case 2: mmmm = "February"; break;
                case 3: mmmm = "March"; break;
                case 4: mmmm = "April"; break;
                case 5: mmmm = "May"; break;
                case 6: mmmm = "June"; break;
                case 7: mmmm = "July"; break;
                case 8: mmmm = "August"; break;
                case 9: mmmm = "September"; break;
                case 10: mmmm = "October"; break;
                case 11: mmmm = "November"; break;
                case 12: mmmm = "Decemeber"; break;
            }

            yyyy = L[2].ToString();

            string[] ArrayString = { dd, mmmm, yyyy };

            return String.Join(" ", ArrayString);
        }

        static string GetDate()
        {
            bool ok = false;
            string ddmmyyyy = "";

            while (!ok)
            {
                Console.Write("Enter date in format dd-mm-yyyy : ");
                ddmmyyyy = Console.ReadLine();
                ok = DateFormatIsValid(ddmmyyyy);
            }
            return ddmmyyyy;
        }

        static void Main(string[] args)
        {
            
            string myDate = GetDate();

            Console.WriteLine($"{myDate} in full is {ExplodeDate(myDate)}");

            Console.ReadKey();
        }
    }
}
