using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdLab {
    class MeatFactory : Factory, IOverhaul {
        public int NumberOfCows { get; set; }
        public int NumberOfChickens { get; set; }
        public int LastOverhaul { get; set; }
        public MeatFactory() : base() {
            ProductionType = "Meat";
            NumberOfCows = 0;
            NumberOfChickens = 0;
            LastOverhaul = 0;
        }
        public MeatFactory(string street, int buildingNumber, DateTime buildTime, int numberOfFloors,
        int numberOfFlats, TypesOfBuilding typeOfBuilding,
        string owner, int income, int capitalization,
        int numberOfCows, int numberOfChickens, int lastOverhaul) : base(street, buildingNumber, buildTime, numberOfFloors, numberOfFlats, typeOfBuilding, owner, income, capitalization) {
            ProductionType = "Meat";
            NumberOfCows = numberOfCows;
            NumberOfChickens = numberOfChickens;
            LastOverhaul = lastOverhaul;
        }
        public int MeatPerMonth() {
            return NumberOfCows * 100 + NumberOfChickens * 5;
        }
        public bool NeedForRepair() {
            if (LastOverhaul < 10) {
                return false;
            }
            else {
                return true;
            }
        }
        public override string ToString() {
            return base.ToString() + "Number Of Cows = " + NumberOfCows + '\n' + "Number Of Chickens = " + NumberOfChickens + '\n'  + "Meat per month = " + MeatPerMonth() + '\n';
        }
    }
}
