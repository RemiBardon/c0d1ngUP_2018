using System;

namespace SW_III {
    class Program {
        static void Main(string[] args) {
            bool ok;

            byte[] n_array;
            byte[] p_array;
            byte[] s_array;

            int[] results = new int[0];

            for (int n = 1111; n <= 9999; n+=2) {
                ok = true;

                n_array = ToByteArray(n);
                for (int i = 0; i < n_array.Length - 1; i++) {
                    if (n_array[i] >= n_array[i+1]) {
                        ok = false;
                    }
                }

                if (ok) {
                    p_array = ToByteArray(Product(n_array));
                    foreach (byte b in p_array) {
                        switch (b) {
                            case 0:
                            case 2:
                            case 4:
                            case 6:
                            case 8:
                                ok = false;
                                break;
                        }
                    }

                    if (ok) {
                        s_array = ToByteArray(Sum(n_array));
                        foreach (byte b in s_array) {
                            switch (b) {
                                case 1:
                                case 3:
                                case 5:
                                case 7:
                                case 9:
                                    ok = false;
                                    break;
                            }
                        }

                        if (ok) {
                            Console.WriteLine(n);
                        }
                    }
                }
            }
            
            Console.ReadLine();
        }

        static byte[] ToByteArray(int n) {
            char[] c = n.ToString().ToCharArray();
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

        static int Product(byte[] Bytes) {
            int p = 1;
            for (int i = 0; i < Bytes.Length; i++) {
                p *= Bytes[i];
            }

            return p;
        }

        static int Sum(byte[] Bytes) {
            int s = 0;
            for (int i = 0; i < Bytes.Length; i++) {
                s += Bytes[i];
            }

            return s;
        }
    }
}