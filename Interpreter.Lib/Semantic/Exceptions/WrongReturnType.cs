using Interpreter.Lib.FrontEnd.GetTokens.Impl;
using Interpreter.Lib.Semantic.Types;

namespace Interpreter.Lib.Semantic.Exceptions
{
    public class WrongReturnType : SemanticException
    {
        public WrongReturnType(Segment segment, Type expected, Type actual) :
            base(
        $"{segment} Wrong return type: expected {expected}, actual {actual}"
        )
        {
        }
    }
}