using Interpreter.Lib.BackEnd;
using Interpreter.Lib.IR.Ast.Visitors;

namespace Interpreter.Lib.IR.Ast.Nodes.Statements;

public class TypeStatement : Statement
{
    private readonly string _typeId;
    private readonly Type _typeValue;

    public TypeStatement(string typeId, Type typeValue)
    {
        _typeId = typeId;
        _typeValue = typeValue;
    }
        
    public override IEnumerator<AbstractSyntaxTreeNode> GetEnumerator()
    {
        yield break;
    }

    protected override string NodeRepresentation() =>
        $"type {_typeId} = {_typeValue}";

    public override AddressedInstructions Accept(InstructionProvider visitor) => new();
}