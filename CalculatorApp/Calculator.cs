using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public static class Calculator
    {
        /// <summary>
        /// Make calculation based on the operation
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <param name="operation">The operation.</param>
        /// <returns></returns>
        /// <exception cref="System.DivideByZeroException">Cannot divide by zero</exception>
        /// <exception cref="System.InvalidOperationException">Invalid operation</exception>
        public static double Calculate(double number1, double number2, char operation)
        {
            if (number2 == 0 && (operation == '/' || operation == '%'))
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            switch (operation)
            {
                case '+':
                    return number1 + number2;
                case '-':
                    return number1 - number2;
                case '*':
                    return number1 * number2;
                case '/':
                    return number1 / number2;
                case '%':
                    return number1 % number2;
                default:
                    throw new InvalidOperationException("Invalid operation");
            }
        }


        /// <summary>
        /// Make calculations on two numbers
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <param name="sum">The sum.</param>
        /// <param name="difference">The difference.</param>
        /// <param name="product">The product.</param>
        /// <param name="quotient">The quotient.</param>
        /// <param name="remainder">The remainder.</param>
        public static void Calculate(double number1, double number2, out double sum, out double difference,
            out double product, out double quotient, out double remainder)
        {
            sum = number1 + number2;
            difference = number1 - number2;
            product = number1 * number2;
            quotient = number1 / number2;
            remainder = number1 % number2;
        }

        /// <summary>
        /// Make calculations on two numbers
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        public static Dictionary<string, double> Calculate(int number1, int number2)
        {
            return new Dictionary<string, double>
            {
                { "sum", number1 + number2 },
                { "difference", number1 - number2 },
                { "product", number1 * number2 },
                { "quotient", (double)number1 / number2 },
                { "remainder", number1 % number2 }
            };
        }
    }
}
