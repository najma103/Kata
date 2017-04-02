using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PillarPencilKata;


namespace PencilKataTest
{

    [TestClass]
    public class PencilTest
    {
        //instantiating class 
        private Pencil pencil, P2;
        public PencilTest()
        {

        }

        [TestInitialize]
        public void SetUp()
        {
            int pencilDurability = 40000;
            int eraserDurability = 20000;
            int pencilLength = 10;
            pencil = new Pencil(pencilDurability, eraserDurability, pencilLength);
        }
       
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
            Assert.AreEqual(4, pencil.PencilLength);
            Assert.AreEqual(40000, pencil.PencilDurability);
        }

        [TestMethod]
        public void EraseWordsAndReplaceWithWhiteSpaces()
        {
            string str = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            string test3 = pencil.TextWriter(str);
            string returnedStr = "How much wood would a woodchuck chuck if a woodchuck could       wood?";
            Assert.AreEqual(returnedStr, pencil.EraseWords("chuck"));

            // if removed again it should remove the next matching string"
            string actual = "How much wood would a woodchuck chuck if a wood      could       wood?";
            Assert.AreEqual(actual, pencil.EraseWords("chuck"));
        }

        [TestMethod]
        public void TestEraserPointDegradation()
        {
            //pencil durability, eraser durability and pencil length
            P2 = new Pencil(100, 5, 2);
            string str = P2.TextWriter("This is a text");
            string expected = "This is a     ";

            Assert.AreEqual(expected, P2.EraseWords("text"));
            Assert.AreEqual(1, P2.EraserDurability);
        }
        [TestMethod]
        public void WhenEraserDoesNotHaveEnoughPointsEraserShouldNotEraseTexts()
        {
            //pencil durability, eraser durability and pencil length
            P2 = new Pencil(100, 4, 2);
            string str = P2.TextWriter("How much wood would a woodchuck chuck");
            string expected = "How much wood w     a woodchuck chuck";

            Assert.AreEqual(expected, P2.EraseWords("would"));
            Assert.AreEqual(0, P2.EraserDurability);
        }
    }
}
