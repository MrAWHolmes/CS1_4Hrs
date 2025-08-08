using System.Transactions;

namespace Tut16_calculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2;
            char op = '+';
            

            if (args.Length == 3 && CanConvertToDouble(args[0]) && OpIsValid(args[1]) && CanConvertToDouble(args[2]))
            {

                string args1 = args[1]; 
                Console.WriteLine("Inputs taken from args command line");
                operand1 = Convert.ToDouble(args[0]);

                //remove white space in args[1]
                

                while (args1.Contains(" "))
                {
                    args1 = args1.Replace(" ", "");
                }
                op = Convert.ToChar(args[1]);

                operand2 = Convert.ToDouble(args[0]);

            }
            else { 
                    
                        operand1 = ReadDouble("Enter operand 1");
                        op = ReadOp();
                        operand2 = ReadDouble("Enter operand 2");

                        
            }//if on input

            double answer = 0; // to preven unsigned variable error

            // perform calculaiton
            switch (op)
            {
                case '+' : answer = operand1 + operand2; break;
                case '-' : answer = operand1 - operand2; break;
                case '*' : answer = operand1 * operand2; break;
                case '/' : if (operand2 != 0)
                            {   answer = operand1 / operand2; 
                                break; 
                            } else
                            {
                                answer = double.NaN;
                                break;  
                            };
                case '%':  if (operand2 != 0)
                            {
                                answer = operand1 % operand2;
                                break;
                            }
                            else
                            {
                                answer = double.NaN;
                                break;
                            };
                case '^': answer = Math.Pow(operand1, operand2); break;

            }//swith (op)


            Console.WriteLine($"{operand1} {op} {operand2} = {answer}");

            // Pause for viewing
            Console.ReadKey();
       }//Main

        static bool CanConvertToDouble(string data)
        {
            bool ok = false;

            try
            {
                double value = Convert.ToDouble(data); // local scope so thrown away!
            }//try
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid input. Exception {ex}");
            }//except
            finally
            {
                ok = true;
            }//finally

            return ok;
        }

        static bool OpIsValid(string op)
        {
            //remove white space
            while(op.Contains(" "))
            {
                op = op.Replace(" ", "");
            }

            if (op.Contains("+")) return true;
            if (op.Contains("-")) return true;
            if (op.Contains("*")) return true;
            if (op.Contains("/")) return true;
            if (op.Contains("%")) return true;
            if (op.Contains("^")) return true;


            return false;
        }

        static char  ReadOp() {
            string opStr = " ";
            char op = ' ';

            while (!OpIsValid(Convert.ToString(op)))
            {
                Console.Write("Operator [+,-,/,*,%,^] :");
                opStr = Console.ReadLine();

                while(opStr.Contains(" "))
                {
                    opStr = opStr.Replace(" ", "");
                }//while white space removal

                if (opStr.Length == 1)   op = Convert.ToChar(opStr[0]);
            }//while !OpIsValid

            return op;
        }
        static double ReadDouble(string prompt)
        {
            
            string data;
            double value=0; // to prevent unassigned error

            Console.Write(prompt + ": ");
            data = Console.ReadLine();

            while (!CanConvertToDouble(data)){
                Console.Write(prompt + ": ");
                data = Console.ReadLine();
            }//while

            return Convert.ToDouble(data);
        }// ReadDouble
        

    }//class Program
}
