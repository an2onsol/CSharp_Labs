using System;
using System.Numerics;

namespace FirstLab {
    class Program {
        public static double DoubleInput() {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Введите чиловое значение\n");
            }
            return number;
        }

        static void Main(string[] args) {
            double ac = 0, bc, cc, dc, D, p, q;
            Complex x1, y1, x2, y2, x3, y3;
            while (ac == 0) {
                Console.WriteLine("Введите ненулевой коафициент при x^3");
                ac = DoubleInput();
            }
            Console.WriteLine("Введите коафициент при x^2");
            bc = DoubleInput();
            Console.WriteLine("Введите коафициент при x");
            cc = DoubleInput();
            Console.WriteLine("Введите свободный член");
            dc = DoubleInput();

            p = (3 * ac * cc - Math.Pow(bc, 2)) / (3 * Math.Pow(ac, 2));
            q = (2 * Math.Pow(bc, 3.0) - 9 * ac * bc * cc + 27 * Math.Pow(ac, 2.0) * dc) / (27 * Math.Pow(ac, 3));
            D = Math.Pow(p / 3, 3) + Math.Pow(q / 2, 2);

            Complex D_i = Complex.Sqrt(D);
            Complex i = new Complex(0, 1);
            Complex z = Complex.Pow(Complex.Add(-q / 2.0, D_i), (1.0 / 3.0));
            Complex t = Complex.Pow(Complex.Add(-q / 2.0, -D_i), (1.0 / 3.0));

            y1 = Complex.Add(z, t);
            y2 = -y1 / 2 + (Complex.Add(z, -t) * Math.Sqrt(3.0) / 2) * i;
            y3 = -y1 / 2 - (Complex.Add(z, -t) * Math.Sqrt(3.0) / 2) * i;
            x1 = y1 - bc / (3.0 * ac);
            x2 = y2 - bc / (3.0 * ac);
            x3 = y3 - bc / (3.0 * ac);

            Console.WriteLine("Решение: x1 = " + x1 + "; x2 = " + x2 + "; x3 = " + x3);
        }
    }
}
