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
using ExampleUIDesignPatterns.CalculatorMVP.Views;
using ExampleUIDesignPatterns.CalculatorMVP.Presenters;

namespace ExampleUIDesignPatterns
{
    public partial class CalculatorMVPView : UserControl, ICalculatorMVPView
    {
        public CalculatorMVPView()
        {
            InitializeComponent();
        }
        
        public CalculatorMVPPresenter Presenter { get; set; }

        private void buttonsAll_Click(object sender, EventArgs e)
        {
            char charEntered = (sender as Button).Text.ToCharArray()[0];
            Presenter.button_Clicked(charEntered);
        }

        public void buttonsAll_SetStyleDefault(char c)
        {
            // UI Requirement: Clear all buttons style.
            foreach (var button in panel1.Controls.OfType<Button>())
            {
                button.FlatStyle = FlatStyle.Standard;
                
                // FIXME: Find a better way to find button.
                // UI Requirement: Make the pressed button flat
                if (button.Text.StartsWith(c.ToString()))
                    button.FlatStyle = FlatStyle.Flat;                
            }
        }

        public void screen_Clear()
        {
            textBox1.Text = "";
            listBox1.Items.Add("CLR");
        }

        public void screen_Update(string text)
        {
            textBox1.Text = text;
        }

        public void history_Append(string text)
        {
            listBox1.Items.Add(text);
        }

        public void screen_SetColor(Color color)
        {
            textBox1.BackColor = color;
        }
    }
}
