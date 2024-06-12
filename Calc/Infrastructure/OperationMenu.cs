namespace CalculatorCsharp;

public sealed class OperationMenu : IMenu<IOperationAlgExecutor<double>>
{
    public OperationMenu(IOperationProvider operationProvider,
        IMenuItemSelector<IOperationAlgExecutor<double>> menuItemSelector)
    {
        this.operationProvider = operationProvider;
        ItemSelector = menuItemSelector;
    }

    private readonly IOperationProvider operationProvider;

    public IMenuItemSelector<IOperationAlgExecutor<double>> ItemSelector { get; }

    public IMenu<IOperationAlgExecutor<double>> Show()
    {
        Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
        int i = 1;
        foreach (IOperation operation in operationProvider.Get())
            Console.WriteLine($"{i++}. ОПЕРАЦИЯ {operation.Name};");
        return this;
    }
}
