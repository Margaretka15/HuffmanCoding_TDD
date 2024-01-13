using HuffmanCoding;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace HuffmanCodingTests
{
    [TestClass]
    public class TokenizerTests
    {
        [TestMethod]
        public void TestCharactersCount()
        {
            string text = "test";
            var result = Tokenizer.countCharacters(text);
            Assert.AreEqual(result.Keys.Count, 3);
            Assert.IsTrue(result.ContainsKey('t'));
            Assert.AreEqual(result['e'], 1);
            Assert.AreEqual(result['t'], 2);

        }

        [TestMethod]
        public void TestSpecialCharactersCount()
        {
            string text = @"Litwo! Ojczyzno moja! ty jesteś jak zdrowie:
                        Ile cię trzeba cenić, ten tylko się dowie,
                        Kto cię stracił. Dziś piękność twą w całej ozdobie
                        Widzę i opisuję, bo tęsknię po tobie.";

            var result = Tokenizer.countCharacters(text);
            Assert.IsTrue(result.ContainsKey('\n'));
            Assert.AreEqual(result[' '], 99);
            Assert.AreEqual(result['.'], 2);


        }

    }
}
