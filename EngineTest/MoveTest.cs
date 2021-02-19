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
        public void IsHorizontal()
        {
            var result = Move.IsHorizontal("E4", "F4");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsVertical()
        {
            var result = Move.IsVertical("E4", "E5");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsDiagonal()
        {
            var result = Move.IsDiagonal("E4", "F5");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsLShape()
        {
            var result = Move.IsLShape("E4", "F6");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsOneInFront()
        {
            var result = Move.IsOneInFront("E5", "E6");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsOne()
        {
            var result = Move.IsOne("E5", "E4");
            Assert.That(result, Is.True);
        }
    }
}
