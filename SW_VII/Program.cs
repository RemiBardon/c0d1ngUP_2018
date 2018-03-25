using System;

namespace SW_VII {
    class Program {
        static void Main(string[] args) {
            byte[] nombres_nbr = new byte[5];
            byte[] produit_nbr = new byte[5];

            bool ok;

            int[] results = new int[0];

            for (int n = 0; n <= 1000; n++) {
                for (int m = 0; m <= 1000; m++) {
                    nombres_nbr = ToByteArray(Convert.ToString(n) + Convert.ToString(m));
                    produit_nbr = ToByteArray(Convert.ToString(n*m));

                    if (nombres_nbr.Length == produit_nbr.Length && produit_nbr.Length <= 4) {
                        ok = true;
                        bool[] equals = new bool[] { false, false, false, false };
                        for (int i = 0; i < produit_nbr.Length; i++) {
                            for (int j = 0; j < produit_nbr.Length; j++) {
                                equals[i] |= (nombres_nbr[i] == produit_nbr[j]);
                            }
                        }
                        if (!(equals[0] && equals[1] && equals[2] && equals[3])) {
                            ok = false;
                        }
                        if (ok) {
                            equals = new bool[] { false, false, false, false };
                            for (int i = 0; i < produit_nbr.Length; i++) {
                                for (int j = 0; j < nombres_nbr.Length; j++) {
                                    equals[i] |= (produit_nbr[i] == nombres_nbr[j]);
                                }
                            }
                            if (!(equals[0] && equals[1] && equals[2] && equals[3])) {
                                ok = false;
                            }
                            if (ok) {
                                Console.WriteLine(n + " * " + m + " = " + (n * m));
                                Array.Resize(ref results, results.Length + 1);
                                results[results.Length - 1] = n * m;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < results.Length; i++) {
                for (int j = 0; j < results.Length; j++) {
                    if (i != j) {
                        if (results[i] == results[j]) {
                            for (int a = 0, b = 0; a < results.Length - 1; a++, b++) {
                                if (a == j) { b++; }
                                results[a] = results[b];
                            }
                            Array.Resize(ref results, results.Length - 1);
                            j--;
                        }
                    }
                }
            }

            string l = "";
            foreach (int r in results) {
                l += Convert.ToString(r) + ", ";
            }
            Console.WriteLine(l);
            Console.WriteLine("Il faut ensuite supprimer les réponses qui ne sont pas bonnes.");
            Console.WriteLine("Ainsi, on a : 1503, 1530, 1255, 1206, 1260, 3784, 6880, 3159, 1395, 1827, 2187, 1435");
            Console.ReadLine();
        }

        private static byte[] ToByteArray(string str) {
            char[] c = str.ToCharArray();
            string[] s = new string[c.Length];
            for (int i = 0; i < c.Length; i++) {
                s[i] = Convert.ToString(c[i]);
            }
            byte[] b = new byte[s.Length];
            for (int i = 0; i < s.Length; i++) {
                b[i] = Convert.ToByte(s[i]);
            }
            return b;
        }
    }
}