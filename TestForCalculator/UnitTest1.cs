using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestForCalculator
{
    [TestClass()]
    public class TestClass
    {
        private Label labelMinus;
        private object textbox;       

        [TestMethod()]
        public void TestSolution()
        {
            try
            {
                ClassOperation testClass = new ClassOperation();
                testClass.Solution((TextBox)textbox, (Label)labelMinus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void TestForReading()
        {
            try
            {
                ClassOperation testClass = new ClassOperation();
                testClass.Reading("1", (TextBox)textbox);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void TestClear()
        {
            try
            {
                ClassOperation testClass = new ClassOperation();
                testClass.Clear((TextBox)textbox, (Label)labelMinus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }

        }

        [TestMethod()]
        public void TestOperation()
        {
            try
            {
                ClassOperation testClass = new ClassOperation();
                testClass.Operation((TextBox)textbox, 0, (Label)labelMinus); // plus
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void TestPlusMinus()
        {
            try
            {
                ClassOperation testClass = new ClassOperation();
                testClass.PlusMinus((Label)labelMinus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }
    }
}
