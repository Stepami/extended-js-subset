namespace Interpreter
{
    public static class TokenTypes
    {
        public const string Json = @"[
        {
          ""tag"": ""Comment"",
          ""pattern"": ""[\/]{2}.*"",
          ""priority"": 0,
          ""whiteSpace"": true
        },
        {
          ""tag"": ""Ident"",
          ""pattern"": ""[a-zA-Z][a-zA-Z0-9]*"",
          ""priority"": 50,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""IntegerLiteral"",
          ""pattern"": ""[0-9]+"",
          ""priority"": 3,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""FloatLiteral"",
          ""pattern"": ""[0-9]+[.][0-9]+"",
          ""priority"": 2,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""NullLiteral"",
          ""pattern"": ""null"",
          ""priority"": 4,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""BooleanLiteral"",
          ""pattern"": ""true|false"",
          ""priority"": 5,
          ""whiteSpace"": false
        }, 
        {
          ""tag"": ""StringLiteral"",
          ""pattern"": ""\\\""(\\\\.|[^\""\\\\])*\\\"""",
          ""priority"": 6,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""Keyword"",
          ""pattern"": ""let|const|function|if|else|while|break|continue|return|as|type"",
          ""priority"": 11,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""Operator"",
          ""pattern"": ""[+]{1,2}|[-]|[*]|[\/]|[%]|([!]|[=])[=]|([<]|[>])[=]?|[!]|[|]{2}|[&]{2}|[~]|[:]{2}"",
          ""priority"": 12,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""Arrow"",
          ""pattern"": ""[=][>]"",
          ""priority"": 13,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""Comma"",
          ""pattern"": ""[,]"",
          ""priority"": 100,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""Dot"",
          ""pattern"": ""[.]"",
          ""priority"": 105,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""LeftCurl"",
          ""pattern"": ""[{]"",
          ""priority"": 101,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""RightCurl"",
          ""pattern"": ""[}]"",
          ""priority"": 102,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""LeftParen"",
          ""pattern"": ""[(]"",
          ""priority"": 103,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""RightParen"",
          ""pattern"": ""[)]"",
          ""priority"": 104,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""LeftBracket"",
          ""pattern"": ""[[]"",
          ""priority"": 107,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""RightBracket"",
          ""pattern"": ""[]]"",
          ""priority"": 109,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""Assign"",
          ""pattern"": ""[=]"",
          ""priority"": 99,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""QuestionMark"",
          ""pattern"": ""[?]"",
          ""priority"": 90,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""Colon"",
          ""pattern"": ""[:]"",
          ""priority"": 91,
          ""whiteSpace"": false
        },
        {
          ""tag"": ""SemiColon"",
          ""pattern"": ""[;]"",
          ""priority"": 92,
          ""whiteSpace"": false
        }
      ]";
    }
}