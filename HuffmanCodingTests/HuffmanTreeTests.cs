using HuffmanCoding;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace HuffmanCodingTests
{
    [TestClass]
    public class HuffmanTreeTests
    {
        [TestMethod]
        public void TestCodeForOneCharacter()
        {
            var dictionary = new Dictionary<char, int>() {
                {'a', 3 }
            };
            var tree = HuffmanTree.EncodeCharacters(dictionary);
            Assert.AreEqual(tree.Keys.Count, 1);
            Assert.AreEqual(tree['a'], "0"); 

        }
        [TestMethod]
        public void TestCodesForTwoCharacters()
        {
            var dictionary = new Dictionary<char, int>() {
                {'a', 3 },  {'b', 2 }
            };
            var tree = HuffmanTree.EncodeCharacters(dictionary);
            Assert.AreEqual(tree.Keys.Count, 2);
            Assert.AreEqual(tree['a'], "0");
            Assert.AreEqual(tree['b'], "1");

        }
        [TestMethod]
        public void TestCodesForMultipleCharacters()
        {
            var dictionary = new Dictionary<char, int>() {
                {'a', 4 },  {'b', 2 },  {'c', 1 }
            };
            var tree = HuffmanTree.EncodeCharacters(dictionary);
            Assert.AreEqual(tree.Keys.Count, 3);
            Assert.AreEqual(tree['a'], "0");
            Assert.AreEqual(tree['b'], "10");
            Assert.AreEqual(tree['c'], "11");

        }

    }
}
