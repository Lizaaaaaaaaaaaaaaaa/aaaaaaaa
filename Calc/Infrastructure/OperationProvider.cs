namespace CalculatorCsharp;

public sealed class OperationProvider : IOperationProvider
{
    private IEnumerable<IOperationAlgExecutor<double>> operations;

    public OperationProvider(IEnumerable<IOperationAlgExecutor<double>> operations)
    {
        this.operations = operations;
    }

    public IEnumerable<IOperationAlgExecutor<double>> Get()
    {
        return operations;
    }
}
