using System;
using ExampleUIDesignPatterns.CalculatorMVP.Models;
using ExampleUIDesignPatterns.CalculatorMVP.Presenters;
using ExampleUIDesignPatterns.CalculatorMVP.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ExampleUIDesignPatterns.Tests
{
    [TestClass]
    public class CalculatorMVP_Presenter_Tests
    {
        Mock<ICalculatorMVPView> viewmock;
        CalculatorMVPModel model;
        CalculatorMVPPresenter presenter;
        PrivateObject objToTestPrivateMethod;

        [TestMethod]
        public void Check_AppendDigit_Operand1_Shifting()
        {
            int initial = 12;
            int newValue = 5;

            // Arrange 
            viewmock    = new Mock<ICalculatorMVPView>();
            model       = new CalculatorMVPModel();
            presenter   = new CalculatorMVPPresenter(viewmock.Object, model);
            model.OperandValue1 = initial;            
            objToTestPrivateMethod = new PrivateObject(presenter);

            //Act
            objToTestPrivateMethod.Invoke("AppendDigit", newValue);

            //Assert
            Assert.AreEqual(125, model.OperandValue1);
        }
    }
}
