using Interpreter.Lib.FrontEnd.Lex;

namespace Interpreter.Lib.Semantic.Exceptions
{
    public class WrongNumberOfArguments : SemanticException
    {
        public WrongNumberOfArguments(Segment segment, int expected, int actual) :
            base(
                $"{segment} Wrong number of arguments: expected {expected}, actual {actual}"
            )
        {
        }
    }
}