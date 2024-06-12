namespace CalculatorCsharp;

public interface IOperationProvider
{
    public IEnumerable<IOperationAlgExecutor<double>> Get();
}
