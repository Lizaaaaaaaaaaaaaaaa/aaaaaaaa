namespace CalculatorCsharp;

public sealed class PowXByYOperation : DoubleMathOperation
{
    public PowXByYOperation(
        IPowXByY executor,
        IOperationArgsProvider<TwoStandartArgs> args)
        : base("X^Y")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly IPowXByY executor;
    private readonly IOperationArgsProvider<TwoStandartArgs> args;

    public override double Execute()
    {
        TwoStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number1, args.Number2);
    }
}
