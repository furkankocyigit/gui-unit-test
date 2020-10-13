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
        public double OperandValue1 { get; set; } = 0;
        public double OperandValue2 { get; set; } = 0;
        public double Result { get; set; } = 0;  
        
        public double Addition()
        {
            return Result = OperandValue1 + OperandValue2;
        }

        public double Substraction()
        {
            return Result = OperandValue1 - OperandValue2;
        }

        public double Multiplication()
        {
            return Result = OperandValue1 * OperandValue2;
        }

        public double Division()
        {
            return Result = OperandValue1 / OperandValue2;
        }

        public void Reset()
        {
            OperandValue1 = OperandValue2 = Result = 0;
        }
    }
}
