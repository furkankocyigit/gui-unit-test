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

        public CalculatorMVPPresenter(ICalculatorMVPView view, CalculatorMVPModel model) // Note: ICalculatorMVPModel could be created for dependency inversion.
        {
            _view = view;
            _model = model;

            // For readability, presenter has been injected upon creation in higher layer (ex: Program.cs).
            // _view.Presenter = this;
        }
        
        public void button_Clicked(char c)
        {
            _view.buttonsAll_SetStyleDefault(c);            
                   
            switch (c)
            {
                case '+':
                    _model.operatorInProgress = CalculatorHelper.Operators.Addition;
                    _model.operand1Active = false;
                    break;
                case '-':
                    _model.operatorInProgress = CalculatorHelper.Operators.Substraction;
                    _model.operand1Active = false;
                    break;
                case 'x':
                    _model.operatorInProgress = CalculatorHelper.Operators.Multiplication;
                    _model.operand1Active = false;
                    break;
                case '/':
                    _model.operatorInProgress = CalculatorHelper.Operators.Division;
                    _model.operand1Active = false;
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
            if (_model.operand1Active)
            {
                _model.operandValue1 = _model.operandValue1 * 10 + value;
                _view.screen_Update(_model.operandValue1.ToString());
            }
            else
            {
                _model.operandValue2 = _model.operandValue2 * 10 + value;
                _view.screen_Update(_model.operandValue2.ToString());
            }
        }

        private void Calculate()
        {
            try
            {
                if (_model.operatorInProgress == CalculatorHelper.Operators.Addition)
                {
                    _view.history_Append(_model.operandValue1.ToString() + "+" + _model.operandValue2.ToString());
                    _model.result = _model.operandValue1 + _model.operandValue2;
                }
                else if (_model.operatorInProgress == CalculatorHelper.Operators.Substraction)
                {
                    _view.history_Append(_model.operandValue1.ToString() + "-" + _model.operandValue2.ToString());
                    _model.result = _model.operandValue1 - _model.operandValue2;
                }
                else if (_model.operatorInProgress == CalculatorHelper.Operators.Multiplication)
                {
                    _view.history_Append(_model.operandValue1.ToString() + "*" + _model.operandValue2.ToString());
                    _model.result = _model.operandValue1 * _model.operandValue2;
                }
                else if (_model.operatorInProgress == CalculatorHelper.Operators.Division)
                {
                    _view.history_Append(_model.operandValue1.ToString() + "/" + _model.operandValue2.ToString());
                    _model.result = _model.operandValue1 / _model.operandValue2;
                }
            }
            catch
            {
                _model.result = 0;
            }

            // UI Requirement: If result is below 0, make textbox yellow. otherwise White.
            if (_model.result < 0)
                _view.screen_SetColor(Color.Yellow);
            else
                _view.screen_SetColor(Color.White);

            _model.operand1Active = true;
            _view.screen_Update(_model.result.ToString());
            _view.history_Append(_model.result.ToString());
            _model.operandValue1 = 0;
            _model.operandValue2 = 0;
        }
    }
}
