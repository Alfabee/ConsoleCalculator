using ConsoleCalculator;

class Program
{
    static void Main(string[] args)
    {
        ICalculator calc = new Calculator();
        ILogger logger = new Logger();
        IValidator validator = new Validator();


        Console.WriteLine("Введіть перше число:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        int b = int.Parse(Console.ReadLine());


        int sum = calc.Add(a, b);
        Console.WriteLine($"Сума: {sum}");
        logger.Log($"Add: {a} + {b} = {sum}");

        int diff = calc.Subtract(a, b);
        Console.WriteLine($"Різниця: {diff}");
        logger.Log($"Subtract: {a} - {b} = {diff}");

        int prod = calc.Multiply(a, b);
        Console.WriteLine($"Добуток: {prod}");
        logger.Log($"Multiply: {a} * {b} = {prod}");

        if (validator.IsValidDivision(b))
        {
            int quot = calc.Divide(a, b);
            Console.WriteLine($"Частка: {quot}");
            logger.Log($"Divide: {a} / {b} = {quot}");
        }
        else
        {
            Console.WriteLine("Помилка: ділення на нуль неможливе.");
            logger.Log($"Divide: {a} / {b} — помилка ділення на 0");
        }


    }
}
