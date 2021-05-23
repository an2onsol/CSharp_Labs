﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdLab {
    class Factory : Building, IComparable<Factory>{
        public string Owner { get; set; }
        public string ProductionType { get; set; }
        public int Income { get; set; }
        public int Capitalization { get; set; }
        public Factory() : base() {
            Owner = "Undef";
            ProductionType = "Undef";
            Income = 0;
            Capitalization = 0;
        }
        public Factory(string street, int buildingNumber, DateTime buildTime, int numberOfFloors,
        int numberOfFlats, TypesOfBuilding typeOfBuilding,
        string owner, string productionType, int income, int capitalization) : base(street, buildingNumber, buildTime, numberOfFloors, numberOfFlats, typeOfBuilding) {
            Owner = owner;
            ProductionType = productionType;
            Income = income;
            Capitalization = capitalization;
        }
        public Factory(string street, int buildingNumber, DateTime buildTime, int numberOfFloors,
        int numberOfFlats, TypesOfBuilding typeOfBuilding,
        string owner, int income, int capitalization) : base(street, buildingNumber, buildTime, numberOfFloors, numberOfFlats, typeOfBuilding) {
            Owner = owner;
            ProductionType = "Undef";
            Income = income;
            Capitalization = capitalization;
        }
        public bool IsRich() {
            if(Capitalization > 1000000000) {
                return true;
            }
            else if(Capitalization > 0) {
                return false;
            }
            throw new ArgumentException("Сapitalization below zero");
        }
        public int CompareTo(Factory other) {
            if (Capitalization > other.Capitalization) {
                return 1;
            }
            else if (Capitalization < other.Capitalization) {
                return -1;
            }
            else {
                return 0;
            }
        }
        public override string ToString() {
            return base.ToString() + "Owner = " + Owner + '\n' +
                "Production Type = " + ProductionType + '\n' +
                "Income = " + Income + '\n' +
                "Capitalization = " + Capitalization + '\n';
        }
    }
}
