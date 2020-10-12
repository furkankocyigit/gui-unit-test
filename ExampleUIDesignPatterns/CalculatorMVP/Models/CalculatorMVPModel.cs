using ExampleUIDesignPatterns.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUIDesignPatterns.CalculatorMVP.Models
{
    public class CalculatorMVPModel
    {
        // _result = (_operandValue1) (_operator (+-x/)) (_operandValue2)
        // Ex: 6 = 2 * 3

        public CalculatorHelper.Operators operatorInProgress;
        public double operandValue1 = 0;
        public double operandValue2 = 0;
        public double result = 0;
        public bool operand1Active = true; // State to hold Current Operand, first? or second?.
    }
}
