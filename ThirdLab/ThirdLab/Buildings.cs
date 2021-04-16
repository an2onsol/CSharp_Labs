using System;
using System.Collections.Generic;

namespace ThirdLab {
    class Buildings {
        int numberOfBuildings = 0;
        private Dictionary<int, Building> BuildingList;
        public Buildings() {
            BuildingList = new Dictionary<int, Building>();
        }
        public Building this[int index] {
            get {
                if (index < 0 && index >= numberOfBuildings) {
                    throw new Exception("There is no such building\n");
                }
                return BuildingList[index];
            }
            set {
                if (index != value.Id) {
                    throw new Exception("There is no such building\n");
                }
                BuildingList[index] = value;
                numberOfBuildings++;
            }
        }
    }
}