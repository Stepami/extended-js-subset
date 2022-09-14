using Interpreter.Lib.FrontEnd.GetTokens.Impl;

namespace Interpreter.Lib.IR.CheckSemantics.Exceptions
{
    public class FunctionWithoutReturnStatement : SemanticException
    {
        public FunctionWithoutReturnStatement(Segment segment) :
            base(segment, "function with non-void return type must have a return statement") { }
    }
}