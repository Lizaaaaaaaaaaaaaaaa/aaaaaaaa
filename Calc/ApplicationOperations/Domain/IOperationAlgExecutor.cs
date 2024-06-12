namespace CalculatorCsharp;

public interface IOperationAlgExecutor<TResult> : IOperation
{
    TResult Execute();
}
