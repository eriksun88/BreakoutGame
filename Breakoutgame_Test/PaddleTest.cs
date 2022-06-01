using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Breakout_Game;

namespace Breakoutgame_Test
{
    /// <summary>
    /// Summary description for PaddleTest
    /// </summary>
    [TestClass]
    public class PaddleTest
    {
       

        [TestMethod]
        public void TestPaddleMoving()
        {
            //arrange
            int speed = 10;
            int maxWidth = 50;
            Paddle paddle = new Paddle();
            paddle.goLeft = true;   
            paddle.goRight = false;


            //act
            paddle.Moving(speed, maxWidth);

            //assert
            Assert.AreEqual(false, paddle.goLeft);
            Assert.AreEqual(false, paddle.goRight);

        }
    }
}
