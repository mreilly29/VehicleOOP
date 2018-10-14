using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP.Tests
{
    [TestFixture]
    public class VehicleTests
    {
        Car car = new Car();
        [Test]
        public void Create_Veh_CTR_1_Input()
        {
            Car car = new Car("Ford");
            string response = car.Make;
            Assert.That(response, Is.EqualTo("Ford"));
        }

        [Test]
        public void Create_Veh_CTR_2_Input()
        {
            Car car = new Car("Ford", "Bronco");
            string response = car.Model;
            Assert.That(response, Is.EqualTo("Bronco"));
        }

        [Test]
        public void Create_Veh_CTR_3_Input()
        {
            Car car = new Car("Ford", "Bronco", "1965");
            string response = car.Year;
            Assert.That(response, Is.EqualTo("1965"));
        }

        [Test]
        public void Set_Engine_Size()
        {
            car.EngSize = 5.0;
            double response = car.EngSize;
            Assert.That(response, Is.EqualTo(5.0));
        }

        [Test]
        public void Set_Rim_Size()
        {
            car.RimSize = 16;
            int response = car.RimSize;
            Assert.That(response, Is.EqualTo(16));
        }

        [Test]
        public void Set_Veh_Color()
        {
            car.Color = "Red";
            string response = car.Color;
            Assert.That(response, Is.EqualTo("Red"));
        }

        [Test]
        public void Get_MPH()
        {
            string response = car.GetMPH(1,7) + " MPG";
            Assert.That(response, Is.EqualTo("9 MPG"));
        }
                
        [Test]
        public void Get_MPG()
        {
            //car.GetMPG(3117, 3579, 9251);
            string response = car.GetMPG(3117, 3579, 9251);
            Assert.That(response, Is.EqualTo("49.94 MPG"));
        }
    }
}
