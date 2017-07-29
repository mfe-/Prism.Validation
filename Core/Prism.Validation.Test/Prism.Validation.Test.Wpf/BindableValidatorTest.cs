using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prism.Validation.Test.Wpf.Mock;

namespace Prism.Validation.Test.Wpf
{
    [TestClass]
    public class BindableValidatorTest
    {
        /// <summary>
        /// Testing <see cref="ValidatableBindableBase.ValidateProperty(string)"/> against WPF <seealso cref="System.Windows.Controls.Validation.GetErrors(System.Windows.DependencyObject)"/>
        /// </summary>
        [TestMethod]
        public void TestValidateProperty_with_CarMock()
        {
            ////setup test enviroment
            //TextBox TextBox = new TextBox();
            //CarMock Car = new CarMock();
            //Car.Name = String.Empty;

            //Binding Binding = new Binding(nameof(Car.Name));
            //Binding.Source = Car;
            //Binding.ValidatesOnDataErrors = true;
            //Binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            //TextBox.SetBinding(TextBox.TextProperty, Binding);

            ////[StringLength(15, MinimumLength = 5, ErrorMessage = "Max 15 digits")]

            ////String - Empty Validation must evaluate false
            //ReadOnlyCollection<ValidationError> Errors = System.Windows.Controls.Validation.GetErrors(TextBox);
            //var ErrorResultWPF = !(Errors.Count > 0);
            //Assert.AreEqual(false, ErrorResultWPF);
            //var ErrorValidateProperty = Car.ValidateProperty(nameof(Car.Name));
            //Assert.AreEqual(ErrorResultWPF, ErrorValidateProperty);

            ////String.Lenght = 5 Validation must evaluate true
            //Car.Name = "12345";
            //Errors = System.Windows.Controls.Validation.GetErrors(TextBox);
            //ErrorResultWPF = !(Errors.Count > 0);
            //Assert.AreEqual(true, ErrorResultWPF);
            //ErrorValidateProperty = Car.ValidateProperty(nameof(Car.Name));
            //Assert.AreEqual(ErrorResultWPF, ErrorValidateProperty);

            ////String.Lenght = 15 Validation must evaluate true
            //Car.Name = "123456789012345";
            //Errors = System.Windows.Controls.Validation.GetErrors(TextBox);
            //ErrorResultWPF = !(Errors.Count > 0);
            //Assert.AreEqual(true, ErrorResultWPF);
            //ErrorValidateProperty = Car.ValidateProperty(nameof(Car.Name));
            //Assert.AreEqual(ErrorResultWPF, ErrorValidateProperty);

            ////String.Lenght = 16 Validation must evaluate false
            //Car.Name = "1234567890123456";
            //Errors = System.Windows.Controls.Validation.GetErrors(TextBox);
            //ErrorResultWPF = !(Errors.Count > 0);
            //Assert.AreEqual(false, ErrorResultWPF);
            //ErrorValidateProperty = Car.ValidateProperty(nameof(Car.Name));
            //Assert.AreEqual(ErrorResultWPF, ErrorValidateProperty);

        }
    }
}
