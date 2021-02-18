using Engine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineTest
{
    class MoveTest
    {
        [Test]
        public void IsHorizontalMove()
        {
            var result = Move.IsHorizontalMove("E4", "F4");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsVerticalMove()
        {
            var result = Move.IsVerticalMove("E4", "E5");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsDiagonalMove()
        {
            var result = Move.IsDiagonalMove("E4", "F5");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsLShapeMove()
        {
            var result = Move.IsLShapeMove("E4", "F6");
            Assert.That(result, Is.True);
        }
    }
}
