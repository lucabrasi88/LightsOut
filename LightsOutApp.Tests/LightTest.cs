using LightsOutApp.Tests.Helpers;
using NUnit.Framework;
using System.Windows.Forms;

namespace LightsOutApp.Tests
{
    [TestFixture]
    public class LightTest
    {
        
        [Test]
        public void IsCheckSuccessTrue()
        {
            // Arrange
            Button[,] _lightsToCheckSuccessTrue = TestUtils.PrepareLightsAllYellow();

            // Act
            bool isCheckSuccess = GameProcess.CheckSuccess(_lightsToCheckSuccessTrue);

            // Assert
            Assert.IsTrue(isCheckSuccess);
        }

        [Test]
        public void IsCheckSuccessFalse()
        {
            // Arrange
            Button[,] _lightsToCheckSuccessTrue = TestUtils.PrepareLightsAllBlack();

            // Act
            bool isCheckSuccess = GameProcess.CheckSuccess(_lightsToCheckSuccessTrue);

            // Assert
            Assert.AreEqual(false, isCheckSuccess);
        }


    }
}
