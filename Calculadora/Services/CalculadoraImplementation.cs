using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImplementation
    {
        private List<string> historyList;

        public CalculadoraImplementation()
        {
            historyList = new List<string>();
        }

        public int Sum(int num1, int num2)
        {
            int res = num1 + num2;
            historyList.Insert(0, $"Result: {res}");

            return res;
        }

        public int Subtraction(int num1, int num2)
        {
            int res = num1 - num2;
            historyList.Insert(0, $"Result: {res}");

            return res;
        }

        public int Multiplication(int num1, int num2)
        {
            int res = num1 * num2;
            historyList.Insert(0, $"Result: {res}");

            return res;
        }

        public double Division(double num1, double num2)
        {
            double res = num1 / num2;
            historyList.Insert(0, $"Result: {res}");

            return res;
        }

        public double Exponentiation(double num1, double num2)
        {
            double res = Math.Pow(num1, num2);
            historyList.Insert(0, $"Result: {res}");

            return res;
        }

        public List<string> history()
        {
            historyList.RemoveRange(3, historyList.Count - 3);

            return historyList;
        }
    }
}