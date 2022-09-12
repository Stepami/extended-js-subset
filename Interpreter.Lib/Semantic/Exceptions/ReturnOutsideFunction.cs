using Interpreter.Lib.FrontEnd.GetTokens.Impl;

namespace Interpreter.Lib.Semantic.Exceptions
{
    public class ReturnOutsideFunction : SemanticException
    {
        public ReturnOutsideFunction(Segment segment) :
            base(
                $"{segment} \"return\" outside function"
            )
        {
        }
    }
}