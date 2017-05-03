using LedTextParser.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LedTextParser.Tests
{
    [TestClass]
    public class RepStringConverterTests
    {
        private RepStringConverter _rsc;
        private RepValidator _rv;

        [TestInitialize]
        public void TestInitialize()
        {
            _rsc = new RepStringConverter();
            _rv = new RepValidator();
        }

        [TestMethod]
        public void CanReturnCorrectString()
        {
            string expectedString = _rsc.ConvertRep("BfffB1dlhll1Adddd1NKNKN1BHBKH1BfNfB1dlhll1Adddd1KKBKK1");
            string actual_string = "CATBREATH";
            Assert.AreEqual(expectedString, actual_string);
        }

        [TestMethod]
        public void CanReturnStringForEmptyInput()
        {
            string expectedString = _rsc.ConvertRep("");
            string actual_string = "I have nothing to convert (but that's okay!)";
            Assert.AreEqual(expectedString, actual_string);
        }

        [TestMethod]
        public void CanReturnErrorMessageForInvalidInput()
        {
            string expectedString = _rsc.ConvertRep("aodih1oih1oi1oidh");
            string actual_string = "You've entered an invalid string!";
            Assert.AreEqual(expectedString, actual_string);
        }

        [TestMethod]
        public void ValidatorReturnsTrueOnValidString()
        {
            bool isStringValid = _rv.ValidatePattern("BfffB1BKKKB1BKKKB1ffffB1");
            Assert.AreEqual(isStringValid, true);
        }
    }
}
