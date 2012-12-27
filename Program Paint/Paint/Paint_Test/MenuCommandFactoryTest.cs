using Paint.Operations.Menu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Paint.Operations.Draw;
using Paint;

namespace Paint_Test
{
    
    
    /// <summary>
    ///This is a test class for MenuCommandFactoryTest and is intended
    ///to contain all MenuCommandFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MenuCommandFactoryTest
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
        ///A test for CreateIMenuCommnadObject
        ///</summary>
        [TestMethod()]
        public void CreateIMenuCommnadObject_NewCommand_Test()
        {
            MenuCommandFactory target = new MenuCommandFactory();

            IDrawingFeatures drawingFeatures = new DrawingFeaturesMock();

            string menuCommandName = "New";

            IMenuCommand actual;

            actual = target.CreateIMenuCommnadObject(drawingFeatures, menuCommandName);

            Assert.IsTrue(actual is NewCommand);
        }

        [TestMethod()]
        public void CreateIMenuCommnadObject_SaveCommand_Test()
        {
            MenuCommandFactory target = new MenuCommandFactory();

            IDrawingFeatures drawingFeatures = new DrawingFeaturesMock();

            string menuCommandName = "Save";

            IMenuCommand actual;

            actual = target.CreateIMenuCommnadObject(drawingFeatures, menuCommandName);

            Assert.IsTrue(actual is SaveCommand);
        }

        [TestMethod()]
        public void CreateIMenuCommnadObject_NullMenuCommand_Test()
        {
            MenuCommandFactory target = new MenuCommandFactory();

            IDrawingFeatures drawingFeatures = new DrawingFeaturesMock();

            string menuCommandName = "file";

            IMenuCommand actual;

            actual = target.CreateIMenuCommnadObject(drawingFeatures, menuCommandName);

            Assert.IsTrue(actual is NullMenuCommand);
        }
    }
}
