using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdLab {
    public enum TypesOfBuilding { 
        Residental,
        Industrial,
        Other,
    }
    public class Building {
        private static int currentId;
        public int Id { get; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int NumberOfFlats { get; set; }
        public int NumberOfFloors { get; set; }
        public TypesOfBuilding TypeOfBuilding { get; set; } 
        public DateTime BuildTime { get; }
        public Building() {
            Id = currentId++;
            Street = "None";
            BuildingNumber = 0;
            NumberOfFlats = 0;
            NumberOfFloors = 0;
            TypeOfBuilding = TypesOfBuilding.Other;
            BuildTime = DateTime.Now;
        }
        public Building(string street, int buildingNumber) {
            Id = currentId++;
            Street = street;
            BuildingNumber = buildingNumber;
            NumberOfFlats = 0;
            NumberOfFloors = 0;
            BuildTime = DateTime.Now;
            TypeOfBuilding = TypesOfBuilding.Other;
        }
        public Building(string street, int buildingNumber, DateTime buildTime, int numberOfFloors, int numberOfFlats, TypesOfBuilding typeOfBuilding) {
            Id = currentId++;
            Street = street;
            BuildingNumber = buildingNumber;
            NumberOfFlats = numberOfFlats;
            NumberOfFloors = numberOfFloors;
            BuildTime = buildTime;
            TypeOfBuilding = typeOfBuilding;
        }
        public override string ToString() {
            return "Building{\n" +
                "Id = " + Id + '\n' +
                "Street = " + Street + '\n' +
                "Building Number = " + BuildingNumber + '\n' +
                "Number Of Flats = " + NumberOfFlats + '\n' +
                "Number Of Floors = " + NumberOfFloors + '\n' +
                "BuildTime = " + BuildTime + '\n' +
                "Type Of Building = " + TypeOfBuilding + '\n' +
                '}';
        }
    }
}
