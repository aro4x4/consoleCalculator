namespace consoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation;
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("Enter first operand:");
            float operand_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter operator + , - , * , / ");
            operation = Console.ReadLine();
            Console.WriteLine("Enter second operand:");
            float operand_2 = Convert.ToInt32(Console.ReadLine());
            float result = 0;
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

        public static float Addition(float operand_1, float operand_2)
        {
            float result = operand_1 + operand_2;
            return result;
        }
        public static float Substraction(float operand_1, float operand_2)
        {
            float result = operand_1 - operand_2;
            return result;
        }
        public static float Multiplication(float operand_1, float operand_2)
        {
            float result = operand_1 * operand_2;
            return result;
        }
        public static float Division(float operand_1, float operand_2)
        {
            float result = operand_1 / operand_2;
            return result;
        }
    }
}
// csharpcorner
