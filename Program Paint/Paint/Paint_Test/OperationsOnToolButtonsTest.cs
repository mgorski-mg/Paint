using Paint.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Paint.Operations.Draw;
using System.Windows.Forms;
using System.Drawing;
using Paint;

namespace Paint_Test
{
    
    
    /// <summary>
    ///This is a test class for OperationsOnToolButtonsTest and is intended
    ///to contain all OperationsOnToolButtonsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OperationsOnToolButtonsTest
    {


        private TestContext testContextInstance;

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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for WidthComboBox_Click
        ///</summary>
        [TestMethod()]
        public void WidthComboBox_ClickTest()
        {
            IDrawingFeatures drawingFeatures = new DrawingFeaturesMock();

            Pen expected = new Pen(Color.Black,40);

            OperationsOnToolButtons target = new OperationsOnToolButtons(drawingFeatures);

            ComboBox sender = new ComboBox();
            sender.Items.AddRange(new object[] { "1", "5", "20", "40" });
            sender.SelectedIndex = 3;

            EventArgs e = new EventArgs(); 

            target.WidthComboBox_Click(sender, e);

            Pen actual = drawingFeatures.Pencil;

            Assert.AreEqual(expected.Width, actual.Width);
        }
    }
}
