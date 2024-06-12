namespace CalculatorCsharp;

public class Application
{
    public Application(
        IMenu<IOperationAlgExecutor<double>> menu)
    {
        this.menu = menu;
    }

    private IMenu<IOperationAlgExecutor<double>> menu;

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            IOperationAlgExecutor<double> operation = menu.Show().ItemSelector.Select();
            Console.Clear();
            Console.WriteLine($"Результат: {operation.Execute()}");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
