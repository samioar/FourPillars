using SafariParkApp;
using NUnit.Framework;
namespace VehicleTests
{
    public class VehicleTests
    {
        [Test]
        public void WhenADefaultVehicle_MovesTwice_ItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40_IsMovedOnce_ItsPositionIs40()
        {
            Vehicle v = new Vehicle(4, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }
        [Test]
        public void WhenNewWeapon_ReturnsCorrectString()
        {
            string Brand = "Airsoft Gun";
            WaterPistol waterPistol = new WaterPistol("Airsoft Gun");
            

            
        }
    }
}