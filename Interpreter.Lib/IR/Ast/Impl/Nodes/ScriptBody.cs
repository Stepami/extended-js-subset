using Interpreter.Lib.BackEnd;
using Interpreter.Lib.IR.Ast.Visitors;
using Interpreter.Lib.IR.CheckSemantics.Visitors;
using Interpreter.Lib.IR.CheckSemantics.Visitors.SymbolTableInitializer;
using Visitor.NET.Lib.Core;

namespace Interpreter.Lib.IR.Ast.Impl.Nodes;

public class ScriptBody : AbstractSyntaxTreeNode
{
    public List<StatementListItem> StatementList { get; }

    public ScriptBody(IEnumerable<StatementListItem> statementList)
    {
        StatementList = new List<StatementListItem>(statementList);
        StatementList.ForEach(item => item.Parent = this);
    }

    public override IEnumerator<AbstractSyntaxTreeNode> GetEnumerator() =>
        StatementList.GetEnumerator();

    protected override string NodeRepresentation() => "Script";

    public override AddressedInstructions Accept(InstructionProvider visitor) =>
        visitor.Visit(this);

    public override Unit Accept(SymbolTableInitializer visitor) =>
        visitor.Visit(this);
}