using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Prism.Validation.Test.UWP.Mock;

namespace Prism.Validation.Test.UWP
{
    [TestClass]
    public class BindableValidatorTest
    {
        /// <summary>
        /// Testing <see cref="ValidatableBindableBase.ValidateProperty(string)" />
        /// </summary>
        [TestMethod]
        public void TestValidateProperty_with_CarMock()
        {
            //setup test enviroment
            CarMock Car = new CarMock();
            Car.Name = String.Empty;


            //[StringLength(15, MinimumLength = 5, ErrorMessage = "Max 15 digits")]

            //String - Empty Validation must evaluate false
            var ErrorValidateProperty = Car.ValidateProperty(nameof(Car.Name));
            Assert.AreEqual(false, ErrorValidateProperty);

            //String.Lenght = 5 Validation must evaluate true
            Car.Name = "12345";
            ErrorValidateProperty = Car.ValidateProperty(nameof(Car.Name));
            Assert.AreEqual(true, ErrorValidateProperty);

            //String.Lenght = 15 Validation must evaluate true
            Car.Name = "123456789012345";
            ErrorValidateProperty = Car.ValidateProperty(nameof(Car.Name));
            Assert.AreEqual(true, ErrorValidateProperty);

            //String.Lenght = 16 Validation must evaluate false
            Car.Name = "1234567890123456";
            ErrorValidateProperty = Car.ValidateProperty(nameof(Car.Name));
            Assert.AreEqual(false, ErrorValidateProperty);

        }
    }
}
