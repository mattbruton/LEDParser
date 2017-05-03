using System;
using System.Collections.Generic;
using System.Linq;
using LedTextParser.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LedTextParser.Tests
{
    [TestClass]
    public class RepStringConverterTests
    {
        private RepStringConverter rsc;

        [TestInitialize]
        public void TestInitialize()
        {
             rsc = new RepStringConverter();
        }

        [TestMethod]
        public void DictionaryContainsAll32Variations()
        {
            int actual_number_of_keys = rsc.BinaryRowDict.Keys.Count;
            int expected_number_of_keys = 32;

            Assert.AreEqual(expected_number_of_keys, actual_number_of_keys);
        }

        [TestMethod]
        public void ValidatorReturnsTrueOnValidString()
        {
            bool isStringValid = rsc.ValidateRep("0BfffB10BKKKB10BKKKB10ffffB1");
            Assert.IsTrue(isStringValid);
        }
    }
}
