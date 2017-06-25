using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace SimpleCalculator.CodedUI
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void TestCalculator()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.TestCalculator();
            this.UIMap.CheckAddition();
            this.UIMap.CheckValue();

        }

        public WpfWindow WinUWindow;

        public WpfEdit TextboxObject(string txtBoxNameProperty)
        {
            var txtBoxProps = new WpfEdit(WinUWindow) {TechnologyName = "MSAA"};
            txtBoxProps.SearchProperties[WpfControl.PropertyNames.AutomationId] = txtBoxNameProperty;
            txtBoxProps.WindowTitles.Add("MainWindow");
            return txtBoxProps;
        }

        public WpfButton ButtonObject(string btnNameProperty)
        {
            var btnProps = new WpfButton(WinUWindow) {TechnologyName = "MSAA"};
            btnProps.SearchProperties[WpfControl.PropertyNames.AutomationId] = btnNameProperty;
            btnProps.WindowTitles.Add("MainWindow");
            return btnProps;
        }

        public WpfComboBox ComboBoxObject(string btnNameProperty)
        {
            var cmbProps = new WpfComboBox(WinUWindow) {TechnologyName = "MSAA"};
            cmbProps.SearchProperties[WpfControl.PropertyNames.AutomationId] = btnNameProperty;
            cmbProps.WindowTitles.Add("MainWindow");
            return cmbProps;
        }

        [TestMethod]
        public void TestCalculatorThroughCode()
        {
            ApplicationUnderTest appObj = ApplicationUnderTest.Launch(@"D:\CSD\Projects\BillManagement\SampleCalculator\bin\Debug\SampleCalculator.exe");
            Assert.AreEqual(appObj.Title,"MainWindow");
            WinUWindow = new WpfWindow();
            WinUWindow.SearchProperties[UITestControl.PropertyNames.Name] = "MainWindow";
            WinUWindow.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.ClassName, "HwndWrapper",PropertyExpressionOperator.Contains));
            WinUWindow.WindowTitles.Add("MainWindow");
            Keyboard.SendKeys(TextboxObject("textBox"),"2");
            Keyboard.SendKeys(TextboxObject("textBox_Copy"), "1");
            WpfComboBox comboObj = ComboBoxObject("comboBox");
            comboObj.SelectedIndex = 1;
            Mouse.Click(ButtonObject("button"));
            var outVal = TextboxObject("textBox_Copy1").Text;
            Assert.AreEqual(outVal,"3");
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
