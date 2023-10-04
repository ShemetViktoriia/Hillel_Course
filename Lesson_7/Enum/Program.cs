
using Enum1;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //DayOfWeekMine dayOfWeek = DayOfWeekMine.Tuesday;
            //int tuesdayNum = (int)DayOfWeekMine.Tuesday;
            //int wednesdayNum = (int)DayOfWeekMine.Wednesday;
            //Console.WriteLine(tuesdayNum);
            //Console.WriteLine(wednesdayNum);

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            double oper1, oper2, result;
            Operation operation;

            Console.Write("Введіть перший операнд ");
            oper1 = GetDoubleNumber();
            Console.Write("Введіть другий операнд ");
            oper2 = GetDoubleNumber();
            Console.Write("Введіть операцію 1- +, 2 - -, 3 - *, 4 - /   ");
            operation = GetOperation();
            result = DoOperation(oper1, oper2, operation);
            Console.WriteLine("{0} {1} {2} = {3}", oper1, operation, oper2, result);
        }

        static Operation GetOperation()
        {
            Operation operation;
            do
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    input = "5";
                }
                operation = (Operation)System.Enum.Parse(typeof(Operation), input);
            }
            while ((int)operation < (int)Operation.Add || (int)operation > (int)Operation.Divide || (int)operation == (int)Operation.None);
            return operation;
        }

        static double GetDoubleNumber()
        {
            double number;
            bool resParse = false;
            do
            {
                string input = Console.ReadLine();
                resParse = double.TryParse(input, out number);
            }
            while (!resParse);
            return number;
        }

        static double DoOperation(double oper1, double oper2, Operation operation)
        {
            double result = 0;
            try
            {
                switch (operation)
                {
                    case Operation.Add:
                        result = oper1 + oper2;
                        break;
                    case Operation.Subtract:
                        result = oper1 - oper2;
                        break;
                    case Operation.Multiply:
                        result = oper1 * oper2;
                        break;
                    case Operation.Divide:
                        result = oper1 / oper2;
                        break;
                    default: throw new ArgumentException();
                }
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}