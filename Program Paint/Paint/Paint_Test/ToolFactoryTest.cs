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
    ///This is a test class for ToolFactoryTest and is intended
    ///to contain all ToolFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ToolFactoryTest
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
        ///A test for CreateIToolObject
        ///</summary>
        [TestMethod()]
        public void CreateIToolObject_RotateTool_Test()
        {
            ToolFactory target = new ToolFactory();

            IDrawingFeatures drawingFeatures = new DrawingFeaturesMock();

            string toolName = "RotateLeft90";

            ITool actual;
            actual = target.CreateIToolObject(drawingFeatures, toolName);

            Assert.IsTrue(actual is RotateTool);
        }

        [TestMethod()]
        public void CreateIToolObject_LineShapeTool_Test()
        {
            ToolFactory target = new ToolFactory();

            IDrawingFeatures drawingFeatures = new DrawingFeaturesMock();

            string toolName = "RoundLine";

            ITool actual;
            actual = target.CreateIToolObject(drawingFeatures, toolName);

            Assert.IsTrue(actual is LineShapeTool);
        }

        [TestMethod()]
        public void CreateIToolObject_NullTool_Test()
        {
            ToolFactory target = new ToolFactory();

            IDrawingFeatures drawingFeatures = new DrawingFeaturesMock();

            string toolName = "figure";

            ITool actual;
            actual = target.CreateIToolObject(drawingFeatures, toolName);

            Assert.IsTrue(actual is NullTool);
        }
    }
}
