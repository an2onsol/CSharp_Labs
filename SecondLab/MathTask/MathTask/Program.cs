using System;

namespace MathTask {
    class Program {
        public static ulong UlongInput() {
            ulong number;
            while (!ulong.TryParse(Console.ReadLine(), out number)) {
                Console.WriteLine("Введите положительное числовое значение");
            }
            return number;
        }

        static int Main(string[] args) {
            ulong a = 1, b = 0, x;
            int sum = 0;
            while (a >= b) {
                Console.WriteLine("Введите первое число: ");
                a = UlongInput();
                Console.WriteLine("Введите второе число: ");
                b = UlongInput();
                if (a >= b) {
                    Console.Clear();
                    Console.WriteLine("Второе число должно быть больше первого");
                }
            }
            if(a == 0) {
                Console.WriteLine("0");
                return 0;
            }
            for(ulong i = a; i <= b; i++) {
                x = i;
                while(x % 2 == 0) {
                    x /= 2;
                    sum++;
                }
            }
            Console.WriteLine(sum);
            return 0;
        }
    }
}
