using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SSP2;
using SSP2.Model;

namespace GameTesting
{
    [TestClass]
    public class UnitTest1
    {
        Model _model;
        Model _model2;


        [TestMethod]
        public void PlayerWinFirstRound()
        {
            _model = new Model();
            _model.StavkaDoesForTest(200,1000,1000,1,2);

            int expected = 1200;

            int result = _model.PlayerPoints;

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void PlayerLoseFirstRound()
        {
            _model2 = new Model();
            _model2.StavkaDoesForTest(200,1000,1000,2,1);

            int expected = 800;

            int result = _model2.PlayerPoints;

            Assert.AreEqual(expected, result);
        }
    }
}
