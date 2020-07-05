/* A C# program to evaluate a given expression where tokens are separated   
   by space.  
   Test Cases:  
     "10 + 2 * 6"            ---> 22  
     "100 * 2 + 12"          ---> 212  
     "100 * ( 2 + 12 )"      ---> 1400  
     "100 * ( 2 + 12 ) / 14" ---> 100      
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace general
{
    public class InfixExpressionEvaluation
    {
        public int evaluate(string expression)
        {
            char[] tokens = expression.ToCharArray();

            // Stack for numbers: 'values'  
            Stack<int> values = new Stack<int>();

            // Stack for Operators: 'ops'  
            Stack<char> ops = new Stack<char>();

            for (int i = 0; i < tokens.Length; i++)
            {
                // Current token is a whitespace, skip it  
                if (tokens[i] == ' ')
                {
                    continue;
                }

                // Current token is a number, push it to stack for numbers  
                if (tokens[i] >= '0' && tokens[i] <= '9')
                {
                    StringBuilder sbuf = new StringBuilder();
                    // There may be more than one digits in number  
                    while (i < tokens.Length && tokens[i] >= '0' && tokens[i] <= '9')
                    {
                        sbuf.Append(tokens[i++]);
                    }
                    values.Push(int.Parse(sbuf.ToString()));
                }

                // Current token is an opening brace, push it to 'ops'  
                else if (tokens[i] == '(')
                {
                    ops.Push(tokens[i]);
                }

                // Closing brace encountered, solve entire brace  
                else if (tokens[i] == ')')
                {
                    while (ops.Peek() != '(')
                    {
                        values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Pop();
                }

                // Current token is an operator.  
                else if (tokens[i] == '+' || tokens[i] == '-' || tokens[i] == '*' || tokens[i] == '/')
                {
                    // While top of 'ops' has same or greater precedence to current  
                    // token, which is an operator. Apply operator on top of 'ops'  
                    // to top two elements in values stack  
                    while (ops.Count > 0 && hasPrecedence(tokens[i], ops.Peek()))
                    {
                        values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }

                    // Push current token to 'ops'.  
                    ops.Push(tokens[i]);
                }
            }

            // Entire expression has been parsed at this point, apply remaining  
            // ops to remaining values  
            while (ops.Count > 0)
            {
                values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
            }

            // Top of 'values' contains result, return it  
            return values.Pop();
        }

        // Returns true if 'op2' has higher or same precedence as 'op1',  
        // otherwise returns false.  
        public bool hasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
            {
                return false;
            }
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // A utility method to apply an operator 'op' on operands 'a'   
        // and 'b'. Return the result.  
        public int applyOp(char op, int b, int a)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new System.NotSupportedException("Cannot divide by zero");
                    }
                    return a / b;
            }
            return 0;
        }
    }
}