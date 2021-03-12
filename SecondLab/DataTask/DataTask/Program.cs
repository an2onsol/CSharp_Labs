using System;
namespace DataTask {
    class Program {
        static void Main(string[] args) {
            int x;
            int[] digits = new int[10];
            string firstFormat = DateTime.Now.ToString("f");
            string secondFormat = DateTime.Now.ToString("g");

            for(int i = 0; i < secondFormat.Length; i++) {
                x = (int)secondFormat[i] - 48;
                if (x >= 0 && x <= 9) {
                    digits[x]++;
                }
            }
            Console.WriteLine(firstFormat);
            Console.WriteLine(secondFormat);
            for(int i = 0; i < 10; i++) {
                Console.WriteLine(i + " : " + digits[i]);
            }
        }
    }
}
