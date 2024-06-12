namespace CalculatorCsharp;

public interface IOperationTrExecutor<TResult> : IOperation
{
    TResult Execute();
}
