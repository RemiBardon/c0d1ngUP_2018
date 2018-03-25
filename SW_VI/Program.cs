using System;

namespace SW_VI {
    class Program {
        static void Main(string[] args) {
            // Last rooling code : 600215
            for (int n = 0; n <= 999999; n++) {
                if (check_code(600215, n) == 1) {
                    Console.WriteLine(n);
                }
            }

            Console.ReadLine();
        }

        static int check_code(int code_precedent, int code_propose) {
            int rounds = 20;
            int i;
            ulong code = (ulong)code_propose;
            for (i = 0; i < rounds; i++) {
                code = (code * 5231) % 999671;
            }
            if (code == (ulong)code_precedent) return 1;
            else return 0;
        }
    }
}