using System;

namespace SW_IV_post_it_2 {
    class Program {
        static void Main(string[] args) {
            int last_x;
            int last_y;
            int new_x = 1694;
            int new_y = 1546;

            for (int i = 0; i < 50; i++) {
                last_x = new_x;
                last_y = new_y;

                new_x = (last_x + 2 * last_y) % 2018;
                if (new_x < 0) {
                    new_x += 2018;
                }
                new_y = (-3 * last_x + last_y) % 2018;
                if (new_y < 0) {
                    new_y += 2018;
                }
            }

            float declinaison = (new_x - 900) / 10;
            float ascension_droite = (new_y / 150) * 2;
            
            Console.WriteLine("Déclinaison : " + declinaison);
            Console.WriteLine("Ascension droite : " + ascension_droite);
            Console.ReadLine();
        }
    }
}