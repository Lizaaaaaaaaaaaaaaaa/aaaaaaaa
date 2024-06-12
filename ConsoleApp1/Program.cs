using System;

class Program
{
    static void Main()
    {
        try
        {
            Start();
        } catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static void Start()
    {
        Application app = new Application(
            new Menu(), 
            new OperationProvider(
                new Operation[] { 
                    new Addition(), 
                    new Substaction(), 
                    new Multiplication(),
                    new Division(),
                }));
        app.Start();
    }
}

public interface IOperationProvider
{
    public IEnumerable<Operation> Get();
}

public class OperationProvider : IOperationProvider
{
    private IEnumerable<Operation> operations;

    public OperationProvider(IEnumerable<Operation> operations)
    {
        this.operations = operations;
    }

    public IEnumerable<Operation> Get()
    {
        return operations;
    }
}

public interface IMenu
{
    public Operation Show(params Operation[] operations);
}

public class Menu : IMenu
{
    public Operation Show(params Operation[] operations)
    {
        Console.WriteLine("Консольный инженерный калькулятор");
        Console.WriteLine("-------------------------------");
        for (int i = 0; i < operations.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {operations[i].Name}");
        }
        Console.WriteLine("Выберите операцию:");
        return operations[Convert.ToInt32(Console.ReadLine()) - 1];
    }
}

public class NewMenu : IMenu
{
    public Operation Show(params Operation[] operations)
    {
        Console.WriteLine("Суперкалькулятор 2.0");
        Console.WriteLine("+++++++++++++++++++++++++++++++++");
        for (int i = 0; i < operations.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {operations[i].Name}");
        }
        Console.WriteLine("Выбери операцию:");
        return operations[Convert.ToInt32(Console.ReadLine()) - 1];
    }
}

public class Application
{
    private IMenu menu;
    private IOperationProvider operationProvider;

    public Application(IMenu menu, IOperationProvider operationProvider)
    {
        this.menu = menu;
        this.operationProvider = operationProvider;
    }

    public void Start()
    {
        while (true)
        {
            IEnumerable<Operation> operations = operationProvider.Get();
            Operation operation = menu.Show(operations.ToArray());
            double result = operation.Run(10, 10);

            Console.WriteLine("Для выхода нажмите Escape, для продолжения нажмите любую клавишу");
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
}

public abstract class Operation
{
    public abstract string Name { get; }

    public abstract double Run(params double[] numbers);
}

public class Addition : Operation
{
    public override string Name => "Сложение";

    public override double Run(params double[] numbers)
    {
        return numbers.Sum();
    }
}

public class Substaction : Operation
{
    public override string Name => "Вычитание";

    public override double Run(params double[] numbers)
    {
        return 0; // вычитание
    }
}

public class Multiplication : Operation
{
    public override string Name => "Умножение";

    public override double Run(params double[] numbers)
    {
        return 0; // умножение
    }
}

public class Division : Operation
{
    public override string Name => "Деление";

    public override double Run(params double[] numbers)
    {
        return 0; // деление
    }
}

public class Cos : Operation
{
    public override string Name => "Косинус";

    public override double Run(params double[] numbers)
    {
        return 0; // cos
    }
}