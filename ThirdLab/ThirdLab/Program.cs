using System;

namespace ThirdLab {
    class Program {
        static void Main(string[] args) {
            Factory CocaCola = new Factory("ул. Островского", 1000, DateTime.Now, 3, 15, TypesOfBuilding.Industrial, "Me", 10000, 1220000);
            Console.WriteLine(CocaCola.ToString());
            Factory Savushkin = new MilkFactory("ул. Ленина", 1000, DateTime.Now, 3, 15, TypesOfBuilding.Industrial, "Me", 140, 12310000, 10);
            Console.WriteLine(Savushkin.ToString());
            MeatFactory Omkk = new MeatFactory("ул. Пушкина", 1000, DateTime.Now, 3, 15, TypesOfBuilding.Industrial, "Me", 12000, 12312312, 10, 200);
            Console.WriteLine(Omkk.ToString());
            MeatFactory MinskMiaso = new MeatFactory();
            Console.WriteLine(MinskMiaso.ToString());

        }
    }
}
