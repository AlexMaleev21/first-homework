namespace dz_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.ActionManager();
        }
    }
    class Calculator
    {
        double leftNumber;
        double rightNumber;
        String actionSign;
        double result;
        List<String> signs = new List<String>()
    {
        "+", "-", "*", "/"
    };
        public void InputManager()
        {
            Console.WriteLine("Введіть перший аргумент (якщо число не ціле, використовуйте кому)");
            while (true)
            {
                try
                {
                    leftNumber = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Будь ласка, введіть число");
                }
            }
            Console.WriteLine("Введіть знак дії, яку хочете виконати");
            while (true)
            {
                actionSign = Console.ReadLine();
                if (signs.Contains(actionSign))
                {
                    break;
                }
                else
                {
                    actionSign = "";
                    Console.WriteLine("Будь ласка, введіть правильний знак дії, яку хочете виконати");
                }
            }
            Console.WriteLine("Введіть другий аргумент (якщо число не ціле, використовуйте кому)");
            while (true)
            {
                try
                {
                    rightNumber = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Будь ласка, введіть число");
                }
            }
        }
        public double Addition()
        {
            return leftNumber + rightNumber;
        }

        public double Substract()
        {
            return leftNumber - rightNumber;
        }

        public double Multiply()
        {
            return leftNumber * rightNumber;
        }

        public double Divide()
        {
            return leftNumber / rightNumber;
        }

        public void ActionManager()
        {
            InputManager();
            switch (actionSign)
            {
                case "+":
                    result = Addition();
                    Console.WriteLine($"{leftNumber} + {rightNumber} = {result}");
                    break;
                case "-":
                    result = Substract();
                    Console.WriteLine($"{leftNumber} - {rightNumber} = {result}");
                    break;
                case "*":
                    result = Multiply();
                    Console.WriteLine($"{leftNumber} * {rightNumber} = {result}");
                    break;
                case "/":
                    result = Divide();
                    Console.WriteLine($"{leftNumber} / {rightNumber} = {result}");
                    break;
            }
        }
    }
}
