using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdLab {
    class MilkFactory : Factory, IOverhaul {
        public delegate void FactoryStatus(string status);
        public event FactoryStatus IsWorking;
        public int NumberOfCows { get; set; }
        public int LastOverhaul { get; set; }
        public MilkFactory() : base() {
            ProductionType = "Milk";
            NumberOfCows = 0;
            LastOverhaul = 0;
        }
        public MilkFactory(string street, int buildingNumber, DateTime buildTime, int numberOfFloors,
        int numberOfFlats, TypesOfBuilding typeOfBuilding,
        string owner, int income, int capitalization,
        int numberOfCows, int lastOverhaul) : base(street, buildingNumber, buildTime, numberOfFloors, numberOfFlats, typeOfBuilding, owner, income, capitalization) {
            ProductionType = "Milk";
            NumberOfCows = numberOfCows;
            LastOverhaul = lastOverhaul;
        }
        public int MilkPerDay() {
            if (NumberOfCows < 0) {
                throw new ArgumentException("The number of cows is less than zero");
            }
            return NumberOfCows * 10;
        }
        public bool NeedForRepair() {
            if (LastOverhaul < 20) {
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
            return base.ToString() + "Number Of Cows = " + NumberOfCows + '\n' + "Milk per day = " + MilkPerDay() + '\n';
        }
    }
}
