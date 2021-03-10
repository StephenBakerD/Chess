using Engine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineTest
{
    public class BoardTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Can_Create_Empty_Board()
        {
            var board = new Board();

            Assert.That(board.Squares.Count, Is.EqualTo(64));
        }
    }
}
