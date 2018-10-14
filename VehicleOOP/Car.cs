using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    //Maggie Reilly 09/19/2018
    public class Car
    {
        //FIELDS
        private string make;
        private string model;
        private string year;
        private double engSize;
        private int rimSize;
        private string color;

        //PROPERTIES
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public double EngSize
        {
            get { return this.engSize; }
            set { this.engSize = value; }
        }

        public int RimSize
        {
            get { return this.rimSize; }
            set { this.rimSize = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        //CONSTRUCTORS
        public Car()
        {

        }

        public Car(string carMake)
        {
            this.Make = carMake;
        }

        public Car(string carMake, string carModel )
        {
            this.Make = carMake;
            this.Model= carModel;
        }
        public Car(string carMake, string carModel, string carYear)
        {
            this.Make = carMake;
            this.Model = carModel;
            this.Year = carYear;
        }

        //METHODS
        public int GetMPH(double distance, double time)
        {
           int mph = (int)Math.Round(distance / (time / 60));
            return mph;
        }

        public string GetMPG(double endOdo, double startOdo, double tankSize)
        {
            string mpg = Math.Round(((startOdo - endOdo)*1000 / tankSize),2) +" MPG";
            return mpg;          
        }
    }
}
