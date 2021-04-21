using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace tprandomizer_poc_main
{ 
    // Expression         := [ "!" ] <Boolean> { <BooleanOperator> <Boolean> } ...
    // Boolean            := <BooleanConstant> | <Expression> | "(" <Expression> ")"
    // BooleanOperator    := "And" | "Or" 
    // BooleanConstant    := "True" | "False"
    
    public class Parser
    {
        public int tokenValue;
        public bool Parse()
        {
            while (Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key != null)
            {
                Console.WriteLine("Parsing Token: " + Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key);
                var boolean = ParseBoolean();
                
                return boolean;
            }

            throw new Exception("Empty expression");
        }

        private bool ParseBoolean()
        {
            
            if (Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key is BooleanValueToken)
            {
                var current = Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key;
                tokenValue++;

                if (current is TrueToken)
                    return true;

                return false;
            }
            var parseBool = false;

            if (Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key is OpenParenthesisToken)
            {
                tokenValue++;

                var expInPars = Parse();

                //If there are no more characters and we have a hanging parenthesis, throw an error
                if (!(Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key is ClosedParenthesisToken))
                    throw new Exception("Expecting Closing Parenthesis but got: " + Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key);
                    
                tokenValue++; 

                return expInPars;
            }
            if (Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key is ClosedParenthesisToken)
            {
                throw new Exception("Unexpected Closed Parenthesis");
            }
            if (Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key is itemToken)
            {
                Console.WriteLine("Token is Item");
                string evaluatedItem = Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Value; 
                tokenValue++;
                if((Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key is CommaToken))
                {
                    Console.WriteLine("Token is comma");
                    tokenValue++;
                    parseBool = LogicFunctions.verifyItemQuantity(evaluatedItem, Int16.Parse(Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Value));
                }
                else
                {
                    parseBool = LogicFunctions.canUseTest(evaluatedItem);
                }
            }
            if (Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key is logicFunctionToken)
            {
                Console.WriteLine("Token is function:" + Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key.ToString());
                parseBool = (bool)typeof(LogicFunctions).GetMethod(Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Value).Invoke(this, null);
                tokenValue++;
            }
            while (Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key is OperandToken)
            {
                Console.WriteLine("Token is Operand");
                var operand = Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key;
                tokenValue++;
                var nextBoolean = ParseBoolean();

                if (operand is AndToken)
                    parseBool = parseBool && nextBoolean;
                else
                    parseBool = parseBool || nextBoolean;
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

        public Dictionary<Token, string> Tokenize()
        {
            Dictionary<Token, string> tokens = new Dictionary<Token, String>();
            
            while (_reader.Peek() != -1)
            {
                
                while (Char.IsWhiteSpace((char) _reader.Peek()))
                {
                    _reader.Read();
                }

                if (_reader.Peek() == -1)
                    break;

                var c = (char) _reader.Peek();
                Console.WriteLine("Current Token: " + c);
                switch (c)
                {
                    case '!':
                        tokens.Add(new NegationToken(), c.ToString());
                        _reader.Read();
                        break;
                    case '(':
                        Console.WriteLine("New Open Parenthesis");
                        tokens.Add(new OpenParenthesisToken(), c.ToString());
                        _reader.Read();
                        break;
                    case ')':
                        Console.WriteLine("New Close Parenthesis");
                        tokens.Add(new ClosedParenthesisToken(), c.ToString());
                        _reader.Read();
                        break;
                    case ',':
                        tokens.Add(new CommaToken(), c.ToString());
                        _reader.Read();
                        break;
                    default:
                        Console.WriteLine("Parsing Keyword");
                        var text = new StringBuilder();
                        if (Char.IsLetter((char) _reader.Peek()))
                        {
                            while ((Char.IsLetter((char) _reader.Peek()) || ((char) _reader.Peek() == '_') && ((char) _reader.Peek() != ')')))
                            {
                                text.Append((char) _reader.Read());
                            }

                            var potentialKeyword = text.ToString();

                            switch (potentialKeyword)
                            {
                                case "true":
                                    tokens.Add(new TrueToken(), potentialKeyword.ToString());
                                    break;
                                case "false":
                                    tokens.Add(new FalseToken(), potentialKeyword.ToString());
                                    break;
                                case "and":
                                    Console.WriteLine("New AndOperator");
                                    tokens.Add(new AndToken(), potentialKeyword.ToString());
                                    break;
                                case "or":
                                    Console.WriteLine("New OROperator");
                                    tokens.Add(new OrToken(), potentialKeyword.ToString());
                                    break;
                                default:
                                if (Enum.IsDefined(typeof(Item), potentialKeyword))
                                {
                                    tokens.Add(new itemToken(), potentialKeyword.ToString());
                                    break;
                                }
                                //If it isnt a keyword, we assume that it is a logic function
                                else
                                {
                                    Console.WriteLine("Function Token: " + potentialKeyword);
                                    tokens.Add(new logicFunctionToken(), potentialKeyword.ToString());
                                    break;
                                }
                            }
                        }
                        else if (Char.IsNumber((char) _reader.Peek()))
                        {
                            Console.WriteLine("Integer Token Added.");
                            tokens.Add(new IntegerToken(), _reader.Peek().ToString());
                        }
                        else
                        {
                            var remainingText = _reader.ReadToEnd() ?? string.Empty;
                            throw new Exception(string.Format("Unknown Grammar: " + remainingText));
                        }
                        _reader.Read();
                        break;
                }
            }
            foreach (KeyValuePair<Token, string> token in tokens)
            {
                Console.WriteLine(token.Value);
            }
            return tokens;
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
        public class logicFunctionToken : Token
        {
            
        }

        public class IntegerToken : Token
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