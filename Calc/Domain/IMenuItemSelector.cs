namespace CalculatorCsharp;

public interface IMenuItemSelector<out T> where T : IOperationAlgExecutor<double>
{
    public T Select();
}
