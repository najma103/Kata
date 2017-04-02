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
        Pencil pencil; 
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
            string str = pencil.TextWriter("This is a text");
            string expected = "This is a     ";

            Assert.AreEqual(expected, pencil.EraseWords("text"));
        }
    }
}
