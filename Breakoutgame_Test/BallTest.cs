using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Breakout_Game;

namespace Breakoutgame_Test
{
    [TestClass]
    public class BallTest
    {
        [TestMethod]
        public void TestBallMoving()
        {
            //arrange
            int speed = 10;
            int expectedLeft = 50;
            int expectedTop = 350;


            Ball ball = new Ball();
            //act
            ball.Moving(speed);
            //assert
            Assert.AreEqual(expectedLeft, ball.Left);
            Assert.AreEqual(expectedTop, ball.Top);
        }
    }
}
