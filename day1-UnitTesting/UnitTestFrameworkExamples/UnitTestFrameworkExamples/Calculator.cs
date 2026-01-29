using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Divider cannot be zero");

            return a / b;
        }

        public string GetGreeting(string name) => $"Hello, {name}!";
    }

    public class MultipleExcept
    {
        public int InputExcept(int input)
        {
            if (input < 1) throw new Exception("Input should be more than 1");
            else if (input == 0) throw new Exception("Input cannot be 0");
            else return input;
        }



    }
}