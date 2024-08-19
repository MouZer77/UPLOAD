using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public double Add(double Number1, double Number2)
        {
            return Number1 + Number2;
        }

        public double Subtract(double Number1, double Number2)
        {
            return Number1 - Number2;
        }

        public double Multiply(double Number1, double Number2)
        {
            return Number1 * Number2;
        }

        public double Divide(double Number1, double Number2)
        {
            return Number1 / Number2;
        }
    }
}