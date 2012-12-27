using Paint.Operations.Draw;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using Paint;

namespace Paint_Test
{
    
    
    /// <summary>
    ///This is a test class for DrawableFactoryTest and is intended
    ///to contain all DrawableFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DrawableFactoryTest
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
        ///A test for CreateADrawableObject
        ///</summary>
        [TestMethod()]
        public void CreateADrawableObject_FillRectangleDrawer_Test()
        {
            DrawableFactory target = new DrawableFactory();

            IDrawingFeatures drawingFeatures = new DrawingFeaturesMock();
            drawingFeatures.DrawingState = DrawingState.DrawFilledRectangle;

            Point startPoint = new Point();

            ADrawable actual;
            actual = target.CreateADrawableObject(drawingFeatures, startPoint);

            Assert.IsTrue(actual is FillRectangleDrawer);
        }

        [TestMethod()]
        public void CreateADrawableObject_CircleDrawer_Test()
        {
            DrawableFactory target = new DrawableFactory();

            IDrawingFeatures drawingFeatures = new DrawingFeaturesMock();
            drawingFeatures.DrawingState = DrawingState.DrawCircle;

            Point startPoint = new Point();

            ADrawable actual;
            actual = target.CreateADrawableObject(drawingFeatures, startPoint);

            Assert.IsTrue(actual is CircleDrawer);
        }
    }
}
