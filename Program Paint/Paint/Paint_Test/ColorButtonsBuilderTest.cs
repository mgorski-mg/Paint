using Paint.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint_Test
{
    
    
    /// <summary>
    ///This is a test class for ColorButtonsBuilderTest and is intended
    ///to contain all ColorButtonsBuilderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ColorButtonsBuilderTest
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
        ///A test for CreateColorPictureBox
        ///</summary>
        [TestMethod()]
        public void CreateColor_Brown_PictureBoxTest()
        { 
            ColorButtonsBuilder_Accessor target = new ColorButtonsBuilder_Accessor(new DrawingFeaturesMock());

            Color color = Color.Brown;

            PictureBox expected = new PictureBox();
            expected.Size = new Size(16, 16);
            expected.BackColor = Color.Brown;

            PictureBox actual;
            actual = target.CreateColorPictureBox(color);

            Assert.AreEqual(expected.Size, actual.Size);
            Assert.AreEqual(expected.BackColor, actual.BackColor);
        }

        [TestMethod()]
        public void CreateColor_Green_PictureBoxTest()
        {
            ColorButtonsBuilder_Accessor target = new ColorButtonsBuilder_Accessor(new DrawingFeaturesMock());

            Color color = Color.Green;

            PictureBox expected = new PictureBox();
            expected.Size = new Size(16, 16);
            expected.BackColor = Color.Green;

            PictureBox actual;
            actual = target.CreateColorPictureBox(color);

            Assert.AreEqual(expected.Size, actual.Size);
            Assert.AreEqual(expected.BackColor, actual.BackColor);
        }
    }
}
