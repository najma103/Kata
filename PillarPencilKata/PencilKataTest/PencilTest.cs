using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PillarPencilKata;


namespace PencilKataTest
{
    /// <summary>
    /// Summary description for PencilTest
    /// </summary>
    [TestClass]
    public class PencilTest
    {
        //instantiating class 
        Pencil pencil; 
        public PencilTest()
        {
            //
            // TODO: Add constructor logic here
            //
            
        }
        [TestInitialize]
        public void SetUp()
        {
            int pencilDurability = 40000;
            int eraserDurability = 20000;
            int pencilLength = 10;
            pencil = new Pencil(pencilDurability, eraserDurability, pencilLength);
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TextWriterTest()
        {
            //Pencil pencil = new Pencil();
            string test = "She sells sea shells";
            string test2 = "She sells sea shells down by the sea shore";
            Assert.AreEqual(test, pencil.TextWriter("She sells sea shells"));
            Assert.AreEqual(test2, pencil.TextWriter(" down by the sea shore"));
        }

        [TestMethod]
        public void SharpenPencilIfLengthIsGreaterThanZero()
        {
            pencil.PencilLength = 0;
            Assert.AreEqual(false, pencil.SharpenPencil());

            pencil.PencilLength = 5;
            Assert.AreEqual(true, pencil.SharpenPencil());
            Assert.AreEqual(40000, pencil.PencilDurability);
        }
    }
}
