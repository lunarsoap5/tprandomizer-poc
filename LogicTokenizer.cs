using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace tprandomizer_poc_main
{ 
    // Expression         := [ "!" ] <Boolean> { <BooleanOperator> <Boolean> } ...
    // Boolean            := <BooleanConstant> | <Expression> | "(" <Expression> ")"
    // BooleanOperator    := "And" | "Or" 
    // BooleanConstant    := "True" | "False"

    
    public class Parser
    {
        private readonly IEnumerator<Token> _tokens;
        LogicFunctions Logic = new LogicFunctions();

        public Parser(IEnumerable<Token> tokens)
        {
            _tokens = tokens.GetEnumerator();
            _tokens.MoveNext();
        }

        public bool Parse()
        {
            while (_tokens.Current != null)
            {
                var boolean = ParseBoolean();
                while (_tokens.Current is OperandToken)
                {
                    var operand = _tokens.Current;
                    if (!_tokens.MoveNext())
                    {
                        throw new Exception("Missing expression after operand");
                    }
                    var nextBoolean = ParseBoolean();

                    if (operand is AndToken)
                        boolean = boolean && nextBoolean;
                    else
                        boolean = boolean || nextBoolean;

                }

                return boolean;
            }

            throw new Exception("Empty expression");
        }

        public bool ParseBoolean()
        {
            if (_tokens.Current is BooleanValueToken)
            {
                var current = _tokens.Current;
                _tokens.MoveNext();

                if (current is TrueToken)
                    return true;

                return false;
            }
            var parseBool = false;

            if (_tokens.Current is OpenParenthesisToken)
            {
                _tokens.MoveNext();

               
                _tokens.MoveNext();
                var expInPars = Parse();


                if (!(_tokens.Current is ClosedParenthesisToken))
                    throw new Exception("Expecting Closing Parenthesis");
                    
                _tokens.MoveNext(); 

                return expInPars;
            }
            if (_tokens.Current is ClosedParenthesisToken)
            {
                throw new Exception("Unexpected Closed Parenthesis");
            }
            if (_tokens.Current is itemToken)
            {
                Token evaluatedItem = _tokens.Current; 
                _tokens.MoveNext();
                if((_tokens.Current is CommaToken))
                {
                    _tokens.MoveNext();
                    parseBool = LogicFunctions.verifyItemQuantity(evaluatedItem.ToString(), Int16.Parse(_tokens.Current.ToString()));
                }
                else
                {
                    parseBool = LogicFunctions.canUseTest(evaluatedItem);
                }
                _tokens.MoveNext(); 
            }

            // since its not a BooleanConstant or Expression in parenthesis, it must be a expression again
            var val = Parse();
            return val;

        }
    }

    public class Tokenizer
    {
        private readonly StringReader _reader;
        private string _text;

        public Tokenizer(string text)
        {
            _text = text;
            _reader = new StringReader(text);
        }

        public IEnumerable<Token> Tokenize()
        {
            var tokens = new List<Token>();
            while (_reader.Peek() != -1)
            {
                while (Char.IsWhiteSpace((char) _reader.Peek()))
                {
                    _reader.Read();
                }

                if (_reader.Peek() == -1)
                    break;

                var c = (char) _reader.Peek();
                switch (c)
                {
                    case '!':
                        tokens.Add(new NegationToken());
                        _reader.Read();
                        break;
                    case '(':
                        tokens.Add(new OpenParenthesisToken());
                        _reader.Read();
                        break;
                    case ')':
                        tokens.Add(new ClosedParenthesisToken());
                        _reader.Read();
                        break;
                    case ',':
                        tokens.Add(new CommaToken());
                        _reader.Read();
                        break;
                    default:
                        var token = ParseKeyword();
                        tokens.Add(token);
                        break;
                }
            }
            return tokens;
        }

        private Token ParseKeyword()
        {
            var text = new StringBuilder();
            if (!Char.IsNumber((char) _reader.Peek()))
            {
                while (Char.IsLetter((char) _reader.Peek()))
                {
                    text.Append((char) _reader.Read());
                }

                var potentialKeyword = text.ToString().ToLower();

                switch (potentialKeyword)
                {
                    case "true":
                        return new TrueToken();
                    case "false":
                        return new FalseToken();
                    case "and":
                        return new AndToken();
                    case "or":
                        return new OrToken();
                    case "canUse(":
                        return new canUseToken();
                    default:
                    if (Enum.IsDefined(typeof(Item), potentialKeyword))
                    {
                        return new itemToken();
                    }
                    else
                    {
                        throw new Exception("Unexpected Character");
                    }
                }
            }
            else
            {
                return new miscToken();
            }
        }
    }
    public class OperandToken : Token
        {
            
        }
        public class OrToken : OperandToken
        {
        }

        public class AndToken : OperandToken
        {
        }

        public class BooleanValueToken : Token
        {
            
        }
        public class miscToken : Token
        {
            
        }

        public class itemToken : Token
        {
            
        }

        public class FalseToken : BooleanValueToken
        {
        }

        public class TrueToken : BooleanValueToken
        {
        }

        public class ParenthesisToken : Token
        {

        }

        public class CommaToken : Token
        {
        }

        public class canUseToken : Token
        {
        }

        public class ClosedParenthesisToken : ParenthesisToken
        {
        }


        public class OpenParenthesisToken : ParenthesisToken
        {
        }

        public class NegationToken : Token
        {
        }

        public abstract class Token
        {

        }

}