using System;

namespace ThirdLab {
    class Program {
        static void Main(string[] args) {
            Building University = new Building("ул. Гикало", 20);
            Console.WriteLine(University.ToString());
            Building Home = new Building("ул. Ленина", 1000, DateTime.Now, 3, 15, TypesOfBuilding.Residental);
            Console.WriteLine(Home.ToString());
        }
    }
}
