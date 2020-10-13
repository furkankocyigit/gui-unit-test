using ExampleUIDesignPatterns.CalculatorMVP.Models;
using ExampleUIDesignPatterns.CalculatorMVP.Views;
using ExampleUIDesignPatterns.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUIDesignPatterns.CalculatorMVP.Presenters
{
    public class CalculatorMVPPresenter
    {
        private ICalculatorMVPView _view;
        private CalculatorMVPModel _model;

        private bool operand1Active = true;                         // State to hold Current Operand, first? or second?.
        private CalculatorHelper.Operators operatorInProgress;
        // _result = (_operandValue1) (_operator (+-x/)) (_operandValue2)
        // Ex: 6 = 2 * 3

        public CalculatorMVPPresenter(ICalculatorMVPView view, CalculatorMVPModel model) // Note: ICalculatorMVPModel could be created for dependency inversion.
        {
            _view = view;
            _model = model;

            // For readability, presenter has been injected during creation in the higher layer (ex: Program.cs).
            // _view.Presenter = this;
        }
        
        public void button_Clicked(char c)
        {
            _view.buttonsAll_SetStyleDefault(c);            
                   
            switch (c)
            {
                case '+':
                    operatorInProgress = CalculatorHelper.Operators.Addition;
                    operand1Active = false;
                    break;
                case '-':
                    operatorInProgress = CalculatorHelper.Operators.Substraction;
                    operand1Active = false;
                    break;
                case 'x':
                    operatorInProgress = CalculatorHelper.Operators.Multiplication;
                    operand1Active = false;
                    break;
                case '/':
                    operatorInProgress = CalculatorHelper.Operators.Division;
                    operand1Active = false;
                    break;
                case '=':
                    Calculate();
                    break;
                case 'C':
                    _view.screen_Clear();
                    break;
                default:
                    AppendDigit(int.Parse(c.ToString()));
                    break;
            }
            
        }

        private void AppendDigit(int value)
        {
            if (operand1Active)
            {
                _model.OperandValue1 = _model.OperandValue1 * 10 + value;
                _view.screen_Update(_model.OperandValue1.ToString());
            }
            else
            {
                _model.OperandValue2 = _model.OperandValue2 * 10 + value;
                _view.screen_Update(_model.OperandValue2.ToString());
            }
        }

        private void Calculate()
        {
            try
            {
                if (operatorInProgress == CalculatorHelper.Operators.Addition)
                {
                    _view.history_Append(_model.OperandValue1.ToString() + "+" + _model.OperandValue2.ToString());
                    _model.Addition();
                }
                else if (operatorInProgress == CalculatorHelper.Operators.Substraction)
                {
                    _view.history_Append(_model.OperandValue1.ToString() + "-" + _model.OperandValue2.ToString());
                    _model.Substraction();
                }
                else if (operatorInProgress == CalculatorHelper.Operators.Multiplication)
                {
                    _view.history_Append(_model.OperandValue1.ToString() + "*" + _model.OperandValue2.ToString());
                    _model.Multiplication();
                }
                else if (operatorInProgress == CalculatorHelper.Operators.Division)
                {
                    _view.history_Append(_model.OperandValue1.ToString() + "/" + _model.OperandValue2.ToString());
                    _model.Division();
                }
            }
            catch
            {
                _model.Reset();
            }

            // UI Requirement: If result is below 0, make textbox yellow. otherwise White.
            if (_model.Result < 0)
                _view.screen_SetColor(Color.Yellow);
            else
                _view.screen_SetColor(Color.White);

            operand1Active = true;
            _view.screen_Update(_model.Result.ToString());
            _view.history_Append(_model.Result.ToString());

            _model.Reset();
        }
    }
}
