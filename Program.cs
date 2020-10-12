using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleUIDesignPatterns
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Since the instances of implementations of ICalculatorMVPView and ICalculatorMVVMView 
            // are located in mainform, (calculatorMVP1 and calculatorMVVM1), 
            // we need to hold Form1 in a variable to acces its members 
            // when initiating the Presenters.
            Form1 mainForm = new Form1();

            // Create Model and Presenter for MVP (View have been already created in Form1's Designer. (calculatorMVP1))
            CalculatorMVP.Models.CalculatorMVPModel calculatorMVPModel = 
                new CalculatorMVP.Models.CalculatorMVPModel();

            CalculatorMVP.Presenters.CalculatorMVPPresenter calculatorMVPPresenter = 
                new CalculatorMVP.Presenters.CalculatorMVPPresenter(mainForm.calculatorMVP1, calculatorMVPModel);

            // Inject Presenter to View. 
            mainForm.calculatorMVP1.Presenter = calculatorMVPPresenter;

            // Create Model and View-Model for MVVM
            //CalculatorMVVM.Models.CalculatorMVVMModel calculatorMVVMModel = new CalculatorMVVM.Models.CalculatorMVPModel();
            //CalculatorMVVM.Presenters.CalculatorMVVMViewModel calculatorMVVMViewModel = new CalculatorMVVM.ViewModels.CalculatorMVVMViewModels(mainForm.calculatorMVVM1, calculatorMVVMModel);

            Application.Run(mainForm);
        }
    }
}
