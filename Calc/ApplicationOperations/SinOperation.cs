namespace CalculatorCsharp;

public sealed class SinOperation : DoubleMathOperation
{
    public SinOperation(
        ISqrt executor,
        IOperationArgsProvider<OneStandartArgs> args)
        : base("Cin")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ISqrt executor;
    private readonly IOperationArgsProvider<OneStandartArgs> args;

    public override double Execute()
    {
        OneStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number);
    }
}
