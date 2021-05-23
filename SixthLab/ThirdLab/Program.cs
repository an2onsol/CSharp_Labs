using System;

namespace ThirdLab {
    class Program {
        static void Main(string[] args) {
            Factory CocaCola = new Factory("ул. Островского", 1000, DateTime.Now, 3, 15, TypesOfBuilding.Industrial, "Me", 10000, 1220000);
            Console.WriteLine(CocaCola.ToString());

            IOverhaul MilkF = new MilkFactory("ул. Ленина", 1000, DateTime.Now, 3, 15, TypesOfBuilding.Industrial, "Me", 140, 12310000, 10, 30);
            Console.WriteLine(MilkF.NeedForRepair().ToString());

            MeatFactory Omkk = new MeatFactory("ул. Пушкина", 1000, DateTime.Now, 3, 15, TypesOfBuilding.Industrial, "Me", 12000, 12312312, 10, 200, 10);
            Console.WriteLine(Omkk.ToString());

            Console.WriteLine(Omkk.CompareTo(CocaCola).ToString());
        }
    }
}
