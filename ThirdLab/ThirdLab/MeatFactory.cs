using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdLab {
    class MeatFactory : Factory{
        public int NumberOfCows { get; set; }
        public int NumberOfChickens { get; set; }
        public MeatFactory() : base() {
            ProductionType = "Meat";
            NumberOfCows = 0;
            NumberOfChickens = 0;
        }
        public MeatFactory(string street, int buildingNumber, DateTime buildTime, int numberOfFloors,
        int numberOfFlats, TypesOfBuilding typeOfBuilding,
        string owner, int income, int capitalization,
        int numberOfCows, int numberOfChickens) : base(street, buildingNumber, buildTime, numberOfFloors, numberOfFlats, typeOfBuilding, owner, income, capitalization) {
            ProductionType = "Meat";
            NumberOfCows = numberOfCows;
            NumberOfChickens = numberOfChickens;
        }

        public int MeatPerMonth() {
            return NumberOfCows * 100 + NumberOfChickens * 5;
        }
        public override string ToString() {
            return base.ToString() + "Number Of Cows = " + NumberOfCows + '\n' + "Number Of Chickens = " + NumberOfChickens + '\n'  + "Meat per month = " + MeatPerMonth() + '\n';
        }
    }
}
