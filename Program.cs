namespace consoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation;
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("Please enter operator + , - , * , / ");
            operation = Console.ReadLine();
            Console.WriteLine("Enter first operand:");
            int operand_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second operand:");
            int operand_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch(operation)
            {
                case "+": {
                    result = Addition(operand_1, operand_2);
                    break;
                }
                case "-": {
                    result = Substraction(operand_1, operand_2);
                    break;
                }
                case "*": {
                    result = Multiplication(operand_1, operand_2);
                    break;
                }
                case "/": {
                    result = Division(operand_1, operand_2);
                    break;
                }
                default:
                    Console.WriteLine("Wrong operation, try again");
                    break;
            }
            Console.WriteLine($"The result is {result}");
            Console.ReadKey();
        }

        public static int Addition(int operand_1, int operand_2)
        {
            int result = operand_1 + operand_2;
            return result;
        }
        public static int Substraction(int operand_1, int operand_2)
        {
            int result = operand_1 - operand_2;
            return result;
        }
        public static int Multiplication(int operand_1, int operand_2)
        {
            int result = operand_1 * operand_2;
            return result;
        }
        public static int Division(int operand_1, int operand_2)
        {
            int result = operand_1 / operand_2;
            return result;
        }
    }
}
// csharpcorner
