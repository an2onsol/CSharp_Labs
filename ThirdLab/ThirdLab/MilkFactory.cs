using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdLab {
    class MilkFactory : Factory{
        public int NumberOfCows { get; set; }
        public MilkFactory() : base() {
            ProductionType = "Milk";
            NumberOfCows = 0;
        }
        public MilkFactory(string street, int buildingNumber, DateTime buildTime, int numberOfFloors,
        int numberOfFlats, TypesOfBuilding typeOfBuilding,
        string owner, int income, int capitalization,
        int numberOfCows) : base(street, buildingNumber, buildTime, numberOfFloors, numberOfFlats, typeOfBuilding, owner, income, capitalization) {
            ProductionType = "Milk";
            NumberOfCows = numberOfCows;
        }

        public int MilkPerDay() {
            return NumberOfCows * 10;
        }
        public override string ToString() {
            return base.ToString() + "Number Of Cows = " + NumberOfCows + '\n' + "Milk per day = " + MilkPerDay() + '\n';
        }
    }
}
