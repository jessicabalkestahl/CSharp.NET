
using System.Text.Json.Nodes;

namespace Exercise6
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Write("[Calculator] ");
            string mathExpression = Console.ReadLine() ?? string.Empty;
            Console.WriteLine($"{mathExpression} = {PerformMathOperation(mathExpression)}");
            
        }

        private static double PerformMathOperation(string expression)
        {
            int operatorIndex = GetOperatorIndex(expression);
            double number1 = double.Parse(SplitString(expression, 0, operatorIndex));
            double number2 = double.Parse(SplitString(expression, operatorIndex + 1, expression.Length));

            return expression[operatorIndex] switch
            {
                '+' => Sum(number1, number2),
                '-' => Sub(number1, number2),
                '*' => Mult(number1, number2),
                '/' => Div(number1, number2),
                _ => -1
            };
        }

        private static string SplitString(string expression, int startingIndex, int endingIndex)
        {
            string result = "";
            
            for (int i = startingIndex; i < endingIndex; i++)
            {
                result += expression[i];
            }

            return result;
        }

        private static int GetOperatorIndex(string expression)
        {
            if (expression.Contains('+')) return expression.IndexOf('+');
            if (expression.Contains('-')) return expression.IndexOf('-');
            if (expression.Contains('*')) return expression.IndexOf('*');
            if (expression.Contains('/')) return expression.IndexOf('/');

            return -1;
        }

        private static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }
        
        private static double Sub(double number1, double number2)
        {
            return number1 - number2;
        }
        
        private static double Mult(double number1, double number2)
        {
            return number1 * number2;
        }
        
        private static double Div(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}


