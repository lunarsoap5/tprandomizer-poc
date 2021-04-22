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
        public void ParserReset()
        {
            Console.WriteLine("Clearing Parser");
            tokenValue = 0;
            Singleton.getInstance().Logic.TokenDict.Clear();
        }
        public bool Parse()
        {
            while (Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key != null && !(tokenValue > Singleton.getInstance().Logic.TokenDict.Count()-1))
            {
                var boolean = ParseBoolean();
                while ((tokenValue <= Singleton.getInstance().Logic.TokenDict.Count()-1) && Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key is OperandToken)
                {
                    var operand = Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key;
                    tokenValue++;
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
                string evaluatedItem = Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Value; 
                tokenValue++;
                if((Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key is CommaToken))
                {
                    tokenValue++;
                    parseBool = LogicFunctions.verifyItemQuantity(evaluatedItem, Int16.Parse(Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Value));
                    tokenValue++;
                }
                else
                {
                    parseBool = LogicFunctions.canUseTest(evaluatedItem);
                    Console.WriteLine("Can Use Item?" + parseBool);  
                }
                return parseBool;
            }
            if (Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Key is logicFunctionToken)
            {
                parseBool = (bool)typeof(LogicFunctions).GetMethod(Singleton.getInstance().Logic.TokenDict.ElementAt(tokenValue).Value).Invoke(this, null);
                tokenValue++;
                return parseBool;
            }
            
            // since its not a BooleanConstant or Expression in parenthesis, it must be a expression again
            var val = Parse();
            return val;
        } 
    }

    public class Tokenizer
    {
        private char[] _reader;
        private string _text;

        public Tokenizer(string text)
        {
            _text = text;
            _reader = text.ToCharArray();
        }

        public Dictionary<Token, string> Tokenize()
        {
            Dictionary<Token, string> tokens = new Dictionary<Token, String>();
            int i = 0;
            while (i < _reader.Length)
            {
                while (Char.IsWhiteSpace((char) _reader[i]))
                {
                    i++;
                }

                switch (_reader[i])
                {
                    case '!':
                        tokens.Add(new NegationToken(), _reader[i].ToString());
                        i++;
                        break;
                    case '(':
                        tokens.Add(new OpenParenthesisToken(), _reader[i].ToString());
                        i++;
                        break;
                    case ')':
                        tokens.Add(new ClosedParenthesisToken(), _reader[i].ToString());
                        i++;
                        break;
                    case ',':
                        tokens.Add(new CommaToken(), _reader[i].ToString());
                        i++;
                        break;
                    default:
                        Console.WriteLine("Parsing Keyword");
                        var text = new StringBuilder();
                        if (Char.IsLetter(_reader[i]))
                        {
                            while (Char.IsLetter(_reader[i]) || (_reader[i] == '_'))
                            {
                                text.Append(_reader[i]);
                                i++;
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
                                    tokens.Add(new AndToken(), potentialKeyword.ToString());
                                    break;
                                case "or":
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
                                    tokens.Add(new logicFunctionToken(), potentialKeyword.ToString());
                                    break;
                                }
                            }
                        }
                        else if (Char.IsNumber(_reader[i]))
                        {
                            tokens.Add(new IntegerToken(), _reader[i].ToString());
                            i++;
                        }
                        else
                        {
                            var remainingText = _reader.ToString() ?? string.Empty;
                            throw new Exception(string.Format("Unknown Grammar: " + remainingText));
                        }
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