using HuffmanCoding;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuffmanCodingTests
{
    [TestClass]
    public class FileEncoderTests
    {
        [TestMethod]
        public void TestEncoderWithOneCharacter()
        {
            Dictionary<char, string> d = new Dictionary<char, string> { { 'a', "0" } };
            List<byte> bytes = FileEncoder.EncodeFile(d, "aaa");
           
            Assert.AreEqual(bytes[0], Encoding.ASCII.GetBytes("a")[0]);
            Assert.AreEqual(bytes[1], Encoding.ASCII.GetBytes("0")[0]);
            Assert.AreEqual(bytes[2], 0);
            Assert.AreEqual(bytes.Count, 3);

        }

        [TestMethod]
        public void TestEncoderWithMultipleCharacters()
        {
            Dictionary<char, string> d = new Dictionary<char, string> { { 'a', "0" }, { 'b', "10" }, { 'c', "11" } };
            List<byte> bytes = FileEncoder.EncodeFile(d, "aaaabbc");

            Assert.AreEqual(bytes[0], Encoding.ASCII.GetBytes("a")[0]);
            Assert.AreEqual(bytes[1], Encoding.ASCII.GetBytes("0")[0]);
            Assert.AreEqual(bytes[2], Encoding.ASCII.GetBytes("b")[0]);
            Assert.AreEqual(bytes[3], Encoding.ASCII.GetBytes("1")[0]);
        }
    }
}
