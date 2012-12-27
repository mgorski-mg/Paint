using Paint.Operations.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Paint.Operations.Draw;
using System.Drawing;
using System.Drawing.Drawing2D;
using Paint;

namespace Paint_Test
{
    
    
    /// <summary>
    ///This is a test class for EraserToolTest and is intended
    ///to contain all EraserToolTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EraserToolTest
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
        ///A test for Execute
        ///</summary>
        [TestMethod()]
        public void Execute_PensilChenge_Test()
        {
            IDrawingFeatures drawingFeatures = new DrawingFeaturesMock();

            EraserTool target = new EraserTool(drawingFeatures);

            Pen expected = new Pen(Color.White);
            expected.StartCap = LineCap.Round;
            expected.EndCap = LineCap.Round;

            target.Execute();

            Pen actual = drawingFeatures.Pencil;

            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.StartCap, actual.StartCap);
            Assert.AreEqual(expected.EndCap, actual.EndCap);
        }
    }
}
