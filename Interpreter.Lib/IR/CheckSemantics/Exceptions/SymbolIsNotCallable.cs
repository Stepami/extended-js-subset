using Interpreter.Lib.FrontEnd.GetTokens.Data;

namespace Interpreter.Lib.IR.CheckSemantics.Exceptions;

public class SymbolIsNotCallable: SemanticException
{
    public SymbolIsNotCallable(string symbol, Segment segment) : 
        base(segment, $"Symbol is not callable: {symbol}") { }
}