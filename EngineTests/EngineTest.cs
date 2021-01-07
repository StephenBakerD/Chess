using NUnit.Framework;
using System;

namespace EngineTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Create_Game()
        {
            //Arrange
            var game = new Game();

            //Act

            //Assert
            Assert.True(true);
        }
    }

    public class Game
    {
        public Game()
        {
        }
    }
}
