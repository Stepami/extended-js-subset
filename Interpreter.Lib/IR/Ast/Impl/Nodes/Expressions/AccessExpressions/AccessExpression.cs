namespace Interpreter.Lib.IR.Ast.Impl.Nodes.Expressions.AccessExpressions;

public abstract class AccessExpression : Expression
{
    public AccessExpression Next { get; private set; }

    public AccessExpression Prev =>
        Parent as AccessExpression;

    protected AccessExpression(AccessExpression prev)
    {
        if (prev is not null)
        {
            Parent = prev;
            prev.Next = this;
        }
    }

    public bool HasNext() =>
        Next is not null;

    public bool HasPrev() =>
        Prev is not null;
}