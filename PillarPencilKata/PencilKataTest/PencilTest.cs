﻿using System;
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
        public PencilTest()
        {
            //
            // TODO: Add constructor logic here
            //
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
            //
            // TODO: Add test logic here
            //
            Pencil pencil = new Pencil();
            Assert.AreEqual("test", pencil.TextWriter("test"));


        }
    }
}
