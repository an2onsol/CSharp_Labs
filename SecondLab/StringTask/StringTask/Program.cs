using System;
using System.Linq;

namespace StringTask {
    class Program {
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split(' ');
            s = s.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", s));
        }
    }
}
