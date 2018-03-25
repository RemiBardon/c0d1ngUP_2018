using System;

namespace SW_I {
    class Program {
        static void Main(string[] args) {
            double D = 0;
            float V = 0;
            float t = 0;

            while (D < 35) {
                D += 3 - 0.005 * V;
                V = (float)(8 * D);
                t++;
            }
            Console.WriteLine("La moitié de la porte est percée à t={0}s, la distance atteinte est de D={1}cm et le volume de métal fondu est de V={2}cm3.", t, D, V);

            while (D < 70) {
                D += 3 - 0.005 * V;
                V = (float)(8 * D);
                t++;
            }
            Console.WriteLine("La totalité de la porte est percée à t={0}s, la distance atteinte est de D={1}cm et le volume de métal fondu est V={2}cm3.", t, D, V);

            Console.ReadLine();
        }
    }
}