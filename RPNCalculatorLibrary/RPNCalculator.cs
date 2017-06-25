using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculatorLibrary
{
    public class RPNCalculator
    {
        private Stack<string> numbers;
        private char[] operands = {'+', '-', '*', '/'};

        public RPNCalculator()
        {
            numbers = new Stack<string>();
        }
    

    public double Calc(string input)
        {
            numbers.Clear();
            string[] tokens = input.Split(',');
            try
            {
                Evaluate(tokens);
            }
            catch (InvalidOperationException)
            {
                return double.NaN;
            }
            if (numbers.Count > 1)
                return double.NaN;
            else
            {
                string value = numbers.Pop();
                double result;
                if (!double.TryParse(value, out result))
                    return double.NaN;
                return result;
            }
        }

        public void Evaluate(string[] tokenStrings)
        {
            foreach (var token in tokenStrings)
            {
                int count = 0;
                foreach (var character in operands)
                {
                    if (!token.Contains(character))
                    {
                        count++;
                    }
                    else
                        break;
                }
                numbers.Push(token);
                if (count != operands.Length)
                {
                    string r = DoOperation().ToString();
                    numbers.Push(r);
                }
            }
        }

        private double DoOperation()
        {
            string token = numbers.Pop();
            try
            {
                switch (token)
                {
                    case "+":
                        return Convert.ToDouble(numbers.Pop()) + Convert.ToDouble(numbers.Pop());
                    case "-":
                        return -(Convert.ToDouble((numbers.Pop())) - Convert.ToDouble(numbers.Pop()));
                    case "*":
                        return Convert.ToDouble(numbers.Pop()) * Convert.ToDouble(numbers.Pop());
                    case "/":
                        return Convert.ToDouble(numbers.Pop()) / Convert.ToDouble(numbers.Pop());
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            return double.NaN;
        }
    }
}
