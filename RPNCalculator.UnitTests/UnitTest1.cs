using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPNCalculator.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private RPNCalculatorLibrary.RPNCalculator rpn;
        [TestInitialize]
        public void Initialize()
        {
            rpn = new RPNCalculatorLibrary.RPNCalculator();
        }

        [TestMethod]
        public void TestRpnAdd()
        {
            double result = rpn.Calc("1,2,+");
            Assert.AreEqual(result, 3);
            double result1 = rpn.Calc("5,1,2,+,4,*,+,3,-");
            Assert.AreEqual(result1, 14);
            double result2 = rpn.Calc("1,-");
            Assert.AreEqual(result2, double.NaN);
            double result3 = rpn.Calc("-");
            Assert.AreEqual(result3, double.NaN);
            double result4 = rpn.Calc("1,2,+,+");
            Assert.AreEqual(result4, double.NaN);
            double result5 = rpn.Calc("1,2,3,4,+,+");
            Assert.AreEqual(result5, double.NaN);
            double result6 = rpn.Calc("1");
            Assert.AreEqual(result6, 1);
            double result7 = rpn.Calc("1,1");
            Assert.AreEqual(result7, double.NaN);
        }
    }
}
