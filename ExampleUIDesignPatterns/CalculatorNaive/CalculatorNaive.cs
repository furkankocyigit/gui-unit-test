using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleUIDesignPatterns.Utilities;

namespace ExampleUIDesignPatterns
{
    public partial class CalculatorNaive : UserControl
    {
        // _result = (_operandValue1) (_operator (+-x/)) (_operandValue2)
        CalculatorHelper.Operators _operator;
        double _operandValue1 = 0;
        double _operandValue2 = 0;
        double _result = 0;
        bool _operand1Active = true; // State to hold Current Operand, first or second.
        
        public CalculatorNaive()
        {
            InitializeComponent();
        }

        private void buttonsAll_Click(object sender, EventArgs e)
        {
            // UI Requirement: Clear all buttons style.
            foreach (var button in panel1.Controls.OfType<Button>())
            {
                button.FlatStyle = FlatStyle.Standard;
            }

            Button btn = sender as Button;
            char charEntered = btn.Text.ToCharArray()[0];

            // UI Requirement: Make the pressed button flat
            btn.FlatStyle = FlatStyle.Flat;

            switch (charEntered)
            {
                case '+':
                    _operator = CalculatorHelper.Operators.Addition;
                    _operand1Active = false;
                    break;
                case '-':
                    _operator = CalculatorHelper.Operators.Substraction;
                    _operand1Active = false;
                    break;
                case 'x':
                    _operator = CalculatorHelper.Operators.Multiplication;
                    _operand1Active = false;
                    break;
                case '/':
                    _operator = CalculatorHelper.Operators.Division;
                    _operand1Active = false;
                    break;
                case '=':
                    Calculate();
                    break;
                case 'C':
                    Clear();
                    break;
                default: // digits from 0 to 9
                    AppendDigit(int.Parse(charEntered.ToString()));
                    break;
            }
            
        }

        private void Clear()
        {
            textBox1.Text = "";
            _result = 0;
            _operand1Active = true;
            _operandValue1 = 0;
            _operandValue2 = 0;

            listBox1.Items.Add("CLR");
        }

        private void Calculate()
        {       
            try
            { 
                if(_operator==CalculatorHelper.Operators.Addition)
                {
                    listBox1.Items.Add(_operandValue1.ToString() + "+" + _operandValue2.ToString());
                    _result = _operandValue1 + _operandValue2;
                }                    
                else if (_operator == CalculatorHelper.Operators.Substraction)
                {
                    listBox1.Items.Add(_operandValue1.ToString() + "-" + _operandValue2.ToString());
                    _result = _operandValue1 - _operandValue2;
                }
                else if (_operator == CalculatorHelper.Operators.Multiplication)
                {
                    listBox1.Items.Add(_operandValue1.ToString() + "*" + _operandValue2.ToString());
                    _result = _operandValue1 * _operandValue2;
                }
                else if (_operator == CalculatorHelper.Operators.Division)
                {
                    listBox1.Items.Add(_operandValue1.ToString() + "/" + _operandValue2.ToString());
                    _result = _operandValue1 / _operandValue2;                    
                }
            }
            catch
            {
                _result = 0;
            }

            // UI Requirement: If result is below 0, make textbox yellow. otherwise White.
            if (_result < 0)
                textBox1.BackColor = Color.Yellow;
            else
                textBox1.BackColor = Color.White;

            _operand1Active = true;
            textBox1.Text = _result.ToString();
            listBox1.Items.Add(_result.ToString());
            _operandValue1 = 0;
            _operandValue2 = 0;
        }

        private void AppendDigit(int value)
        {
            // value is in between 0 and 9.
            if (_operand1Active)
            {
                _operandValue1 = _operandValue1 * 10 + value;
                textBox1.Text = _operandValue1.ToString();
            }
            else
            {
                _operandValue2 = _operandValue2 * 10 + value;
                textBox1.Text = _operandValue2.ToString();
            }                       
        }
    }
}
