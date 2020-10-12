using ExampleUIDesignPatterns.CalculatorMVP.Presenters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUIDesignPatterns.CalculatorMVP.Views
{
    public interface ICalculatorMVPView
    {
        CalculatorMVPPresenter Presenter { get; set; }

        void buttonsAll_SetStyleDefault(char c);

        void screen_Clear();

        void screen_Update(string text);

        void screen_SetColor(Color color);

        void history_Append(string text);
    }
}
