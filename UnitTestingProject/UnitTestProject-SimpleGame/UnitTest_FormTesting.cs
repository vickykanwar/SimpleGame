using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleGame;

namespace UnitTestProject_SimpleGame
{
    [TestClass]
    public class UnitTest_FormTesting
    {
        //Arrange - we need to make an instance of the class 
        Game Obj_Game = new Game();
        [TestMethod]
        public void shoot_fire_TestMethod_Positive()
        {
                       
            //Act - we need to push some data through our method and get an output            
            var Actual = Obj_Game.shoot_fire(5);             
            //Assert - we need to check the output we get is what we expected            
            Assert.AreEqual(6, Actual); 
        }
        [TestMethod]
        public void shoot_fire_TestMethod_Nagetive()
        {
            //Act - we need to push some data through our method and get an output            
            var Actual = Obj_Game.shoot_fire(4);
            //Assert - we need to check the output we get is what we expected            
            Assert.AreNotEqual(6, Actual);
        }
    }
}
