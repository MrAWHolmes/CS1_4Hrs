namespace tut05_data_types
{
    /* ref 1: Youtube : How to print Unicode text on console windows using c#
     * ref 2: CND AQA A LEvel 7517 - 4.5.4 Range and precision pf binary numbers
     * ref 3: CNC AQA A LEvel 7517 - 4.5.4 Rounding, absolute and relative errors
     * ABSOLUTE ERROR : |Actual - Approx |
     * RELATIVE ERROR : ABS ERROR / Actual
     * Eg) Abs Error = 0.1 - 0.9375 = 0.00625
     *     Rel Error = 0.00625 / 0.1 = 0.0625 = 6.25%
     */
    internal class Program
    {
    

        static void Main(string[] args)
        {
            //this is required for printing out unicode correctly!
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            const string PI = "3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502841027019385211055596446229489549303819644288109756659334461284756482337867831652712019091";
            string name = "PI";
            const char pi = '\x03C0';
            float floatPI = float.Parse(PI);
            double doublePI = double.Parse(PI);
            decimal decimalPI = decimal.Parse(PI);

            Console.WriteLine($"Welcom to the wonders of {name} aka {pi}");
            Console.WriteLine($"Pi on next line:\n{PI}");
            Console.WriteLine($"float pi   = {floatPI}");
            Console.WriteLine($"double pi  = {doublePI}");
            Console.WriteLine($"decimal pi = {decimalPI}");

            Console.WriteLine();

            Console.WriteLine($"Abs Error = |decimal - float| = {Math.Abs(decimalPI-Convert.ToDecimal(floatPI))}");
            Console.WriteLine($"Rel Error = |abs Err| / actual = {100 * Math.Abs(decimalPI - Convert.ToDecimal(floatPI))/decimalPI}%");



            Console.ReadLine();

        }
    }
}
