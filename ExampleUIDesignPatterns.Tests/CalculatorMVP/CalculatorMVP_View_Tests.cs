using System;
using ExampleUIDesignPatterns.CalculatorMVP.Models;
using ExampleUIDesignPatterns.CalculatorMVP.Presenters;
using ExampleUIDesignPatterns.CalculatorMVP.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ExampleUIDesignPatterns.Tests
{
    [TestClass]
    public class CalculatorMVP_View_Tests
    {
        Mock<ICalculatorMVPView> viewmock;
        CalculatorMVPModel model;
        CalculatorMVPPresenter presenter;

        [TestMethod]
        public void Check_Clear_Called_Only_Once()
        {
            char ch = 'C';

            // Arrange 
            viewmock    = new Mock<ICalculatorMVPView>();
            model       = new CalculatorMVPModel();
            presenter   = new CalculatorMVPPresenter(viewmock.Object, model);

            viewmock.Setup(v => v.screen_Clear());

            //Act
            presenter.button_Clicked(ch);

            //Assert
            viewmock.Verify(v => v.screen_Clear(), Times.Once());
        }

        [TestMethod]
        public void Check_SetStyle_Called_Only_Once()
        {
            char ch = '5';

            // Arrange 
            viewmock = new Mock<ICalculatorMVPView>();
            model = new CalculatorMVPModel();
            presenter = new CalculatorMVPPresenter(viewmock.Object, model);

            viewmock.Setup(v => v.buttonsAll_SetStyleDefault(ch));

            //Act
            presenter.button_Clicked(ch);

            //Assert
            viewmock.Verify(v => v.buttonsAll_SetStyleDefault(ch), Times.Once());
        }

    }
}
