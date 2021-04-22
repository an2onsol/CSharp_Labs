using System;
using System.Runtime.InteropServices;

namespace Fibonachi {
    class Program {
        [DllImport("Fibonachi.dll", CallingConvention = CallingConvention.Cdecl))]
        public static extern int SumOfNumbers(int index);

        [DllImport("Fibonachi.dll", CallingConvention = CallingConvention.Cdecl))]
        public static extern int Find(int value);

        [DllImport("Fibonachi.dll", CallingConvention = CallingConvention.Cdecl))]
        public static extern int ValueOfIndex(int index);

        static void Main(string[] args) {
            Console.WriteLine(SumOfNumbers(10));
            Console.WriteLine(Find(5));
            Console.WriteLine(ValueOfIndex(4));
        }
    }
}
