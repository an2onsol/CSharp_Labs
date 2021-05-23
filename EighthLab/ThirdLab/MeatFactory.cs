using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdLab {
    class MeatFactory : Factory, IOverhaul {
        public delegate void FactoryStatus(string status);
        public event FactoryStatus IsWorking;
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
            if(NumberOfChickens < 0 || NumberOfCows < 0) {
                throw new ArgumentException("The number of cows or chickens is less than zero");
            }
            return NumberOfCows * 100 + NumberOfChickens * 5;
        }
        public bool NeedForRepair() {
            if (LastOverhaul < 10) {
                return false;
            }
            else if (LastOverhaul > 0) {
                return true;
            }
            throw new ArgumentException("The number of years since last overhaul is less than zero");
        }
        public string WorkingStatus() {
            if (NeedForRepair()) {
                return "Not working";
            }
            else {
                return "Working";
            }
        }
        public override string ToString() {
            IsWorking?.Invoke(WorkingStatus());
            return base.ToString() + "Number Of Cows = " + NumberOfCows + '\n' + "Number Of Chickens = " + NumberOfChickens + '\n'  + "Meat per month = " + MeatPerMonth() + '\n';
        }
    }
}
