namespace CalculatorCsharp;

public interface IMenu<out T> where T : IOperationAlgExecutor<double>
{
    public IMenu<T> Show();
    public IMenuItemSelector<T> ItemSelector { get; }
}
