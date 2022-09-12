using AutoMapper;
using Interpreter.Lib.FrontEnd.GetTokens.Impl;
using Interpreter.Models;

namespace Interpreter.Services.Providers.Impl
{
    public class LexerProvider : ILexerProvider
    {
        private readonly IMapper _mapper;

        public LexerProvider(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Lexer CreateLexer(LexerQueryModel lexerQuery)
        {
            var domain = lexerQuery.GetStructure(_mapper);
            return new Lexer(domain);
        }
    }
}