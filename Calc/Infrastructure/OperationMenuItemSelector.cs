namespace CalculatorCsharp;

public sealed class OperationMenuItemSelector : IMenuItemSelector<IOperationAlgExecutor<double>>
{
    public OperationMenuItemSelector(
        IMenuItemSelectorProvider selector,
        IOperationProvider operationProvider)
    {
        this.selector = selector;
        this.operationProvider = operationProvider;
    }

    private readonly IMenuItemSelectorProvider selector;
    private readonly IOperationProvider operationProvider;

    public IOperationAlgExecutor<double> Select()
    {
        int id = selector.GetMenuItemId();
        return operationProvider.Get().ElementAt(id - 1);
    }
}
