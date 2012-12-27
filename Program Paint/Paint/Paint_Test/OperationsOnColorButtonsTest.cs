using Paint.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Paint.Operations.Draw;
using Paint;
using System.Windows.Forms;
using System.Drawing;

namespace Paint_Test
{
    
    
    /// <summary>
    ///This is a test class for OperationsOnColorButtonsTest and is intended
    ///to contain all OperationsOnColorButtonsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OperationsOnColorButtonsTest
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
        ///A test for ColorButton_Click
        ///</summary>
        [TestMethod()]
        public void YellowColorButton_ClickTest()
        {
            DrawingFeaturesMock drawingFeatures = new DrawingFeaturesMock();
 
            OperationsOnColorButtons target = new OperationsOnColorButtons(drawingFeatures); 

            PictureBox sender = new PictureBox();
            sender.BackColor = Color.Yellow; 

            EventArgs e = new EventArgs(); 

            Color expected = Color.Yellow;

            target.ColorButton_Click(sender, e);

            Assert.AreEqual(expected, drawingFeatures.Pencil.Color);
        }

        [TestMethod()]
        public void BlueColorButton_ClickTest()
        {
            DrawingFeaturesMock drawingFeatures = new DrawingFeaturesMock();

            OperationsOnColorButtons target = new OperationsOnColorButtons(drawingFeatures);

            PictureBox sender = new PictureBox();
            sender.BackColor = Color.Blue;

            EventArgs e = new EventArgs();

            Color expected = Color.Blue;

            target.ColorButton_Click(sender, e);

            Assert.AreEqual(expected, drawingFeatures.Pencil.Color);
        }

        [TestMethod()]
        public void OrangeColorButton_ClickTest()
        {
            DrawingFeaturesMock drawingFeatures = new DrawingFeaturesMock();

            OperationsOnColorButtons target = new OperationsOnColorButtons(drawingFeatures);

            PictureBox sender = new PictureBox();
            sender.BackColor = Color.Orange;

            EventArgs e = new EventArgs();

            Color expected = Color.Orange;

            target.ColorButton_Click(sender, e);

            Assert.AreEqual(expected, drawingFeatures.Pencil.Color);
        }
    }
}
