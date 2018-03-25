using System;

namespace SW_IV {
    class Program {
        static void Main(string[] args) {
            int x = 930;
            int y = 321;
            int z = 967;

            while (10 * x > y) {
                x = (y * z) % 10000;
                y = (3 * z) % 10000;
                z = (7 * z) % 10000;
            }

            Console.WriteLine("{0}, {1}, {2}", x, y, z);
            Console.ReadLine();
        }
    }
}